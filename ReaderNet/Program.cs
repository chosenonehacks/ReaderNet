﻿using System;
using System.Reflection;

namespace ReaderNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cat ToucherNet.exe | base64 | tr -d "\n" > toucherNet.b64.txt
            //then copy/paste the content of toucherNet.b64.txt into str1 and str2
            string str1 = @"TVqQAAMAAAAEAAAA//8AALgAAAAAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgAAAAA4fug4AtAnNIbgBTM0hVGhpcyBwcm9ncmFtIGNhbm5vdCBiZSByd";

            string str2 = @"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mlidXRlAEFzc2VtYmx5Q29tcGFueUF0dHJpYnV0ZQBSdW50aW1lQ29tcGF0aWJpbGl0eUF0dHJpYnV0ZQBUb3VjaGVyTmV0LmV4ZQBTeXN0ZW0uUnVudGltZS5WZXJzaW9uaW5nAFN0cmluZwBQYXRoAEZpbGVTdHJlYW0AUHJvZ3JhbQBTeXN0ZW0ATWFpbgBBcHBEb21haW4AZ2V0X0N1cnJlbnREb21haW4AU3lzdGVtLlJlZmxlY3Rpb24ARXhjZXB0aW9uAFN0cmVhbVdyaXRlcgBUZXh0V3JpdGVyAC5jdG9yAFN5c3RlbS5EaWFnbm9zdGljcwBTeXN0ZW0uUnVudGltZS5JbnRlcm9wU2VydmljZXMAU3lzdGVtLlJ1bnRpbWUuQ29tcGlsZXJTZXJ2aWNlcwBEZWJ1Z2dpbmdNb2RlcwBhcmdzAEV4aXN0cwBDb25jYXQAT2JqZWN0AFRvdWNoZXJOZXQAQXBwZW5kVGV4dABnZXRfTm93AGdldF9CYXNlRGlyZWN0b3J5AAAAAAARZgBpAGwAZQAuAHQAeAB0AAA1RgBpAGwAZQAgAHQAbwB1AGMAaABlAGQAIABzAHUAYwBjAGUAcwBzAGYAdQBsAGwAeQAhAAAnQQBuACAAZQByAHIAbwByACAAbwBjAGMAdQByAHIAZQBkADoAIAAAAAAAf16/NVYoL0yPcAPri5f4hgAEIAEBCAMgAAEFIAEBEREEIAEBDgQgAQECCAcEDg4SRRJJBAAAEk0DIAAOBQACDg4OBAABAg4FAAESWQ4EAAARYQYAAgEOEWEFAAESRQ4EIAEBHAQAAQEOCLd6XFYZNOCJBQABAR0OCAEACAAAAAAAHgEAAQBUAhZXcmFwTm9uRXhjZXB0aW9uVGhyb3dzAQgBAAIAAAAAAA8BAApUb3VjaGVyTmV0AAAFAQAAAAAXAQASQ29weXJpZ2h0IMKpICAyMDIzAAApAQAkYjI4ZDlhMTUtZWYzYS00NGYyLTkwMDAtNGM1NTI5NmM4ODQwAAAMAQAHMS4wLjAuMAAATQEAHC5ORVRGcmFtZXdvcmssVmVyc2lvbj12NC44LjEBAFQOFEZyYW1ld29ya0Rpc3BsYXlOYW1lFC5ORVQgRnJhbWV3b3JrIDQuOC4xAAAAAAuRRsoAAAAAAgAAAFYAAAAMKQAADAsAAAAAA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";

            try
            {
                byte[] assemblyBytes = Convert.FromBase64String(str1 + str2);

                Assembly assembly = Assembly.Load(assemblyBytes);

                MethodInfo entryPoint = assembly.EntryPoint;
                if (entryPoint != null)
                {
                    object entryPointInstance = null;
                    if (!entryPoint.IsStatic)
                    {
                        entryPointInstance = Activator.CreateInstance(entryPoint.DeclaringType);
                    }

                    ParameterInfo[] parameters = entryPoint.GetParameters();
                    object[] methodArgs = new object[parameters.Length];

                    entryPoint.Invoke(entryPointInstance, methodArgs);
                }

                Console.WriteLine("Assembly loaded and executed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}