using WhenIsEaster.App.Logic.GaussFormula;
namespace WhenIsEaster.App
{
  internal class Program
  {
    static void Main(string[] args)
    {
      ConsoleIO.ConsoleIO.Welcome();
      bool keepPlaying;
      do
      {
        int easterYear = ValidationUtility.IntValidationHelper.GetIntegerRange("\tVilket år vill du hitta datumet för påsk på: ", 1583, 2599, "\n\tNu tog du allt i lite för mycket! Vi kör för tillfället\n\tpå den greogrianska kalendern så försök hålla dig\n\tmellan intervallet ");

        GuassClass dateOfEaster = new GuassClass(easterYear);

        Console.WriteLine(dateOfEaster);
        Console.WriteLine();
        keepPlaying = ValidationUtility.BoolValidationHelper.PromptForYesOrNo("\tVill du hitta påsk på ett annat årtal? (J)a eller (N)ej: ", "\tVar snäll och svara (J)a eller (N)ej.");
      } while (keepPlaying);

      ConsoleIO.ConsoleIO.Goodbye();
    }
  }
}