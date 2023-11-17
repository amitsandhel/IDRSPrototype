using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDatabase1;
using ClassLibraryDatabase1.Models;
using ClassLibraryDatabase1.Data;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryDatabase1;

public class IndexViewModel
{
    public IndexViewModel()
    {

    }

    // Initialize the repository class
    public Repository repo = new Repository();

    // Method to get all TTS survey Years
    public List<Models.Year> GetTTSYears(Newttsadmv1Context context)
    {
        return repo.GetAllYearsFromDatabase(context);
    }

    public List<Models.Tabulation> GetTTSTabulations(Newttsadmv1Context context)
    {
        return repo.GetAllTabulations(context);
    }
    public List<Models.Category> GetTTSCategories(Newttsadmv1Context context)
    {
        return repo.GetAllCategories(context);
    }

    /// <summary>
    /// Get the description of the year for the TTS survey and check what to return
    /// </summary>
    /// <param name="context">instance of context</param>
    /// <param name="yearDescription">the yearId to pass</param>
    /// <returns></returns>
    public string GetYearDescription(Newttsadmv1Context context, int yearDescription)
    {
        var ans = repo.GetYearDescription(context, yearDescription);
        // if statement to check if empty ignore
        return ans.Description;
    }
}
