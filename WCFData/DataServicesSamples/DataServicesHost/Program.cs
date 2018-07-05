using System;
using System.Data.Services;
using System.ServiceModel;

namespace Wrox.ProCSharp.DataServices
{
  class Program
  {
    static void Main()
    {
      try
      {
        var host = new DataServiceHost(typeof(MenuDataService), 
          new Uri[] { new Uri("http://localhost:9000/Samples") });
        host.Open();

        Console.WriteLine("service running");
        Console.WriteLine("Press return to exit");
        Console.ReadLine();
        if (host.State == CommunicationState.Opened)
          host.Close();
      }
      catch (CommunicationException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
