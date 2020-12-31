using MatthiWare.CommandLine;
using System;

namespace ConsoleAppAgrs
{
    class Program
    {
        static void Main(string[] args)
        {
            var option = new CommandLineParserOptions
            {
                AppName = "ConsoleAppAgrs"
            };

            var parser = new CommandLineParser<ParamOptions>();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // -v
            parser.AddCommand<ParamOptions>().Name("-v")
                .Required(false)
                .Description("Show version app")
                .OnExecuting(() =>
                {
                    Console.Write("Version App 7.1");
                });

            var result = parser.Parse(args);

            if (result.HasErrors)
            {
                Console.Error.WriteLine("Parsing error ... ");
            }

            var programOption = result.Result;

            if (programOption.AutoFillName == true)
            {
                programOption.UserName = "NguyenVanCuong";
            }

            //Console.WriteLine("Show all param : ");
            if (!string.IsNullOrEmpty(programOption.UserName))
                Console.WriteLine($"Show Username >> {programOption.UserName}");

            if (!string.IsNullOrEmpty(programOption.FullName))
                Console.WriteLine($"Show FullName >> {programOption.FullName}");

            var old = programOption.Old;
            if (old != 0) Console.WriteLine($"Show Old >> {programOption.Old}");
            //if (!string.IsNullOrEmpty(programOption.Version.))
                // Console.WriteLine($"Show Version >> {programOption.Version}");
            if (programOption.AutoFillName == true)
                Console.WriteLine($"Show AutoFillName is >> {programOption.AutoFillName}");



        }

    }
}
