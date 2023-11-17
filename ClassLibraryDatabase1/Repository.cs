using ClassLibraryDatabase1.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDatabase1;

public class Repository
{
    //initialized the constructor
    public Repository() { }

    // List of all years in a TTS survey
    public List<Models.Year> Years { get; set; } = default!;
    //Get all TTS surveys that exists in the database
    public List<Models.Year> GetAllYearsFromDatabase(Newttsadmv1Context context)
    {
        return context.Years.ToList();
    }
    // Get all Tabulations
    public List<Models.Tabulation> GetAllTabulations(Newttsadmv1Context context)
    {
        return context.Tabulations.ToList();
    }

    // Get all categories
    public List<Models.Category> GetAllCategories(Newttsadmv1Context context)
    {
        return context.Categories.ToList();
    }

    /// <summary>
    /// Method to get the tts info description if applicable
    /// </summary>
    /// <param name="context">instance of the context service</param>
    /// <param name="yearId">the id of the year to get the year object</param>
    /// <returns></returns>
    public Models.Year GetYearDescription(Newttsadmv1Context context, int yearId)
    {
        return context.Years.Where(x => x.Id == yearId).FirstOrDefault();
    }
}
