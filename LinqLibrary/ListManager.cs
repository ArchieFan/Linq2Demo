using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
  public class ListManager
  {
    public static List<Person> LoadSampleData()
    {
      var output = new List<Person>();

      output.Add(new Person { FirstName = "Archie", LastName = "Fan", Birthday = Convert.ToDateTime("1973/03/23"), YearsExperience = 20 });
      output.Add(new Person { FirstName = "GuiZhen", LastName = "Liu", Birthday = Convert.ToDateTime("1986/11/22"), YearsExperience = 12 });
      output.Add(new Person { FirstName = "YuKiu", LastName = "Fan", Birthday = Convert.ToDateTime("2010/05/15"), YearsExperience = 1 });
      output.Add(new Person { FirstName = "ShunChi", LastName = "Fan", Birthday = Convert.ToDateTime("2015/11/26"), YearsExperience = 8 });
      output.Add(new Person { FirstName = "Jamie", LastName = "Doe", Birthday = Convert.ToDateTime("1970/2/18"), YearsExperience = 7 });
      output.Add(new Person { FirstName = "Mary", LastName = "Smith", Birthday = Convert.ToDateTime("1970/1/23"), YearsExperience = 16 });

      return output;
    }




  }
}
