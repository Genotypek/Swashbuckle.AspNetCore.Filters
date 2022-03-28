﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;

namespace Swashbuckle.AspNetCore.Filters.Test.TestFixtures.Fakes.Examples
{
    public class MultipleTypesRequestExamples : IMultipleExamplesProvider
    {
        public IEnumerable<SwaggerExample<object>> GetExamples()
        {
            yield return new SwaggerExample
            {
                Name = "Animal",
                Summary = "Posts Animal",
                Value = new AnimalRequest
                {
                    Name = "Milo",
                    Race = "Husky",
                    IsNeutered = true
                }
            };

            yield return new SwaggerExample
            {
                Name = "Human",
                Summary = "Posts Person",
                Value = new PersonRequest
                {
                    FirstName = "Anthony",
                    Age = 25,
                    Title = Title.Dr,
                    Income = 4220.58M
                }
            };
        }
    }
}