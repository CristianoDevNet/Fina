using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class UpdateCategoryRequest : CreateCategoryRequest
{
    public long Id { get; set; }
}