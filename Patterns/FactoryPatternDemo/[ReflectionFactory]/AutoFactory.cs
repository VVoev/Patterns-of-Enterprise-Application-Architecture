using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryPatternDemo._ReflectionFactory_
{
    public class AutoFactory
    {
        Dictionary<string, Type> autos;

        public AutoFactory()
        {
            LoadTypesICanReturn();
        }

        Type GetTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains(carName))
                {
                    return autos[auto.Key];
                }
            }

            return null;
        }

        public IAuto CreateInstance(string carName)
        {
            Type t = GetTypeToCreate(carName);
            if (t == null)
            {
                //return new AutoNull();
            }

            return Activator.CreateInstance(t) as IAuto;
        }


        public void LoadTypesICanReturn()
        {
            autos = new Dictionary<string, Type>();
            Type[] typesInThisAssemly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssemly)
            {
                if (type.GetInterface(typeof(IAuto).ToString()) != null)
                {
                    autos.Add(type.Name.ToLower(), type);

                }
            }
        }
    }

}
