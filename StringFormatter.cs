using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    
    /// <summary>
    /// Change the string array to a comma-separated list
    /// Wrap each element in the specified quote string.
    /// <param name="items">String array, cannot be null</param>
    /// <param name="quote">String, a specified quote string. e.g. "|", "\", ...</param>
    /// <returns>
    ///     e.g.: if items = ["Hello", "World"]
    ///              quote = "|"
    ///         string result = "|Hello|, |World|"
    /// </returns>
    /// <exception cref="ArgumentNullException">Throw when parameters are null</exception>
    /// </summary>
    public class StringFormatter
    {

        //Code to improve
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            if (items is null)
                throw new ArgumentNullException(nameof(items), "items cannot be null");
            
            if (quote is null) 
                throw new ArgumentNullException(nameof(quote), "quote cannot be null");

            if (items.Length == 0)
                return string.Empty;
            
            StringBuilder qry = new StringBuilder();
            for (int i = 0; i < items.Length; i++)
            {
                if (i > 0)
                {
                    qry.Append(",");
                }
                qry.Append(quote);
                qry.Append(items[i]);
                qry.Append(quote);
            }
            return qry.ToString();
        }
    }
}
