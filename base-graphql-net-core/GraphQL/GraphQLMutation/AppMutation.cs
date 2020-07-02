using base_graphql_net_core.Entities;
using base_graphql_net_core.GraphQL.GraphQLTypes;
using base_graphql_net_core.Repository;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.GraphQL.GraphQLMutation
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation(IUserRepository userRepository)
        {
            Field<UserType>(
                "createUser",
                arguments:  new QueryArguments(
                    new QueryArgument<NonNullGraphType<UserInputType>> { Name = "user"}),
                resolve: context =>
                {
                    var user = context.GetArgument<User>("user");
                    return userRepository.CreateUser(user);
                });

            Field<UserType>(
                "updateUser",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id"},
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "name"}
                    ),
                resolve: context =>
                {
                    var userId = context.GetArgument<int>("id");
                    var name = context.GetArgument<string>("name");
                    return userRepository.UpdateUser(userId, name);
                });

            Field<StringGraphType>(
                "deleteUser",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var userId = context.GetArgument<int>("id");
                    return userRepository.DeleteUser(userId);

                });
        }
    }
}
