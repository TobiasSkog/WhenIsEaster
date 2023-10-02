namespace WhenIsEaster.ValidationUtility
{
  /// <summary>
  /// Validation Helper Class for Booleans.
  /// </summary>
  public class BoolValidationHelper
  {
    public static bool PromptForYesOrNo(string prompt = "Answer (Y)es or (N)o: ", string errorMessage = "Invalid input. Answer must be (Y)es or (N)o.")
    {
      while (true)
      {
        string userInput = StringValidationHelper.GetString(prompt).Trim().ToUpper();
        if (userInput == "YES" || userInput == "Y" || userInput == "JA" || userInput == "J")
        {
          return true;
        }
        if (userInput == "NO" || userInput == "N" || userInput == "NEJ" || userInput == "N")
        {
          return false;
        }

        Console.WriteLine(errorMessage);
      }
    }

    public static bool ValidateAgeRestriction(DateTime userDateOfBirth, int ageRestriction)
    {
      DateTime dateToday = DateTime.Now;

      int userAge = dateToday.Year - userDateOfBirth.Year;

      if (userAge >= ageRestriction)
      {
        return true;
      }
      return false;
    }


  }
}