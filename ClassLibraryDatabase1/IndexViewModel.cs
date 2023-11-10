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

}
