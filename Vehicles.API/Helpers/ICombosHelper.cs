using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Vehicles.API.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetCombosDocumentType();
        IEnumerable<SelectListItem> GetCombosProcedures();
        IEnumerable<SelectListItem> GetCombosVehicleType();
        IEnumerable<SelectListItem> GetCombosBrands();
    }
}
