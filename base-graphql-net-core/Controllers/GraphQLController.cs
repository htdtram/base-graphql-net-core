using System;
using System.Threading.Tasks;
using base_graphql_net_core.GraphQL.GraphQLQuery;
using GraphQL;
using GraphQL.Http;
using GraphQL.Instrumentation;
using GraphQL.Types;
using GraphQL.Validation.Complexity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace base_graphql_net_core.Controllers
{
    [Route("/graphql")]
    public class GraphQLController : Controller
    {
        private readonly IDocumentExecuter _documentExecuter;
        private readonly ISchema _schema;
        private readonly IDocumentWriter _writer;

        public GraphQLController(ISchema schema, IDocumentWriter writer, IDocumentExecuter documentExecuter)
        {
            _schema = schema;
            _writer = writer;
            _documentExecuter = documentExecuter;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GraphQLQuery query)
        {
            if (query == null) { throw new ArgumentNullException(nameof(query)); }
            var inputs = query.Variables.ToInputs();

            var result = await _documentExecuter.ExecuteAsync(x =>
            {
                x.Schema = _schema;
                x.Query = query.Query;
                x.OperationName = query.OperationName;
                x.Inputs = inputs;

                x.ComplexityConfiguration = new ComplexityConfiguration { MaxDepth = 15 };
                x.FieldMiddleware.Use<InstrumentFieldsMiddleware>();

            });

            var json = await _writer.WriteToStringAsync(result);

            if (result.Errors?.Count > 0)
            {
                return BadRequest(result);
            }

            return Ok(JObject.Parse(json));

            //var executionOptions = new ExecutionOptions
            //{
            //    Schema = _schema,
            //    Query = query.Query,
            //    OperationName = query.OperationName,
            //    Inputs = inputs,

            //    ComplexityConfiguration = new ComplexityConfiguration { MaxDepth = 15 },
            //    FieldMiddleware.Use<InstrumentFieldsMiddleware>(),
            //};

            //var result = await _documentExecuter.ExecuteAsync(executionOptions).ConfigureAwait(false);
        }
    }
}
