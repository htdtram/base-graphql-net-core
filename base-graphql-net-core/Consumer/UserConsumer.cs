using base_graphql_net_core.Consumer.CustomResponses;
using base_graphql_net_core.Entities;
using GraphQL;
using GraphQL.Client.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Consumer
{
    public class UserConsumer
    {
        private readonly IGraphQLClient _client;
        public UserConsumer(IGraphQLClient client)
        {
            _client = client;
        }

        public async Task<List<User>> GetUsers()
        {
            var query = new GraphQLRequest
            {
                Query = @"
                         {
                            users {
                                name
                            }

                         }"
            };
            var response = await _client.SendQueryAsync<ResponseUserCollectionType>(query);
            return response.Data.Users;
        }
    }
}
