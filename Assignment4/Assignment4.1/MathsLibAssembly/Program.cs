using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace MathsLibAssembly
{
    internal class Program
    {

        public static object[] CallFunction(MethodInfo method)
        {
            ParameterInfo[] parameters = method.GetParameters();
            object[] arguments = new object[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                Console.WriteLine("Enter the value for {0} parameter, of type {1} ", parameters[i].Name, parameters[i].ParameterType);
                string paramInput = Console.ReadLine();
                Object paramterToRespectiveType = Convert.ChangeType(paramInput, parameters[i].ParameterType);

                arguments[i] = paramterToRespectiveType;
                
            }
            return arguments;
        }
        static void Main(string[] args)
        {
            string path = "F:\\data\\C-DAC\\MyGitData\\gfsdds\\NET\\Assignment_Workspace\\ClassLibrary1\\bin\\Debug\\net6.0\\MathsLib.dll";

            Assembly assembly = Assembly.LoadFrom(path);

            Type[] types = assembly.GetTypes();

            foreach (Type t in types)
            {
                object dynamicallyCreatedObject = assembly.CreateInstance(t.FullName);
                MethodInfo[] methodInfos = t.GetMethods();
              
                    Console.WriteLine(methodInfos[1].Name);
                    int choice;
                    do
                    {
                        Console.WriteLine("0. Exit");
                        Console.WriteLine("1. Add");
                        Console.WriteLine("2. Sub");
                        Console.WriteLine("3. Mult");
                        Console.WriteLine("4. Div");
                        Console.WriteLine("Enter the choice :");
                         choice = Convert.ToInt32(Console.ReadLine());
                    object[] parameterToMethods;
                    object output;
                        switch (choice)
                        {
                            case 1:
                                     parameterToMethods = CallFunction(methodInfos[0]);
                                     output = t.InvokeMember(methodInfos[0].Name, BindingFlags.Public | BindingFlags.Instance| BindingFlags.InvokeMethod, null,dynamicallyCreatedObject,parameterToMethods);
                                    Console.WriteLine("Result "+ output);
                                    
                                    break;
                            case 2:
                                {
                                  parameterToMethods = CallFunction(methodInfos[1]);
                                     output = t.InvokeMember(methodInfos[1].Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, dynamicallyCreatedObject, parameterToMethods);
                                    Console.WriteLine("Result " + output);
                                    
                                    break;
                                }
                        case 3:
                            {
                                parameterToMethods = CallFunction(methodInfos[2]);
                                output = t.InvokeMember(methodInfos[2].Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, dynamicallyCreatedObject, parameterToMethods);
                                Console.WriteLine("Result " + output);

                                break;
                            }
                        case 4:
                            {
                                parameterToMethods = CallFunction(methodInfos[3]);
                                output = t.InvokeMember(methodInfos[3].Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, dynamicallyCreatedObject, parameterToMethods);
                                Console.WriteLine("Result " + output);

                                break;
                            }
                        default:
                            Console.WriteLine("Invlid Input");
                                break;
                        }


                    } while (choice !=0);
                }

            
        }
        }
    }
