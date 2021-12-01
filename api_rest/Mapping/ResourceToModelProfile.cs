using api_rest.Domain.Models;
using api_rest.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rest.Mapping
{
    public class ResourceToModelProfile
    {
        CreateMap<SaveCategoryResource, Category>();
    }
}
