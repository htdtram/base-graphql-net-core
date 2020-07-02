using base_graphql_net_core.GraphQL.GraphQLTypes;
using base_graphql_net_core.Repository;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.GraphQL.GraphQLQuery
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(ICategoryRepository categoryRepository, IUserRepository userRepository, IPostRepository postRepository)
        {
            Field<ListGraphType<CategoryType>>(
                "categories",
                resolve: context =>  categoryRepository.GetCategories()
                );

            Field<ListGraphType<PostType>>(
                "posts",
                resolve: context => postRepository.GetPosts()
                );

            Field<ListGraphType<UserType>>(
                "users",
                resolve: context => userRepository.GetUsers()
                );

            Field<UserType>(
                "user",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }
                    ),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return userRepository.GetUserById(id);
                }
            );
        }
    }
}
