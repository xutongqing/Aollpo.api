using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aollpo.api.SwaggerHelp
{
    /// <summary>
    /// Swagger 帮助类
    /// </summary>
    public class SwaggerTag : IDocumentFilter
    {
        /// <summary>
        /// 帮助方法
        /// </summary>
        /// <param name="swaggerDoc"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Tags = new List<OpenApiTag>
            {
                new OpenApiTag{Name = "Values",Description="test"},
            };
        }
    }
}
