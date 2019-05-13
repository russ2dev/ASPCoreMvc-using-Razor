using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Core_Test.Pages.Admin
{
    public class AddEditRecipeModelModel : PageModel
    {
        [FromRoute]
        public long? Id { get; set; }

        public bool IsNewRecipe
        {
            get { return Id == null; }
        }

        public AddEditRecipeModelModel Recipe { get; set; }
        public void OnGet()

        {
        }
    }
}