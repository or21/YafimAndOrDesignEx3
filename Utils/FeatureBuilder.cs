//-----------------------------------------------------------------------
// <copyright file="FeaturesBuilder.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Reflection;

namespace Utils
{
    /// <summary>
    /// This is the Factory class
    /// </summary>
    public class FeaturesBuilder
    {
        /// <summary>
        /// The current project assembly
        /// </summary>
        private Assembly m_Assembly;

        public FeaturesBuilder(Assembly i_Assembly)
        {
            m_Assembly = i_Assembly;
        }

        /// <summary>
        /// Loads feature according to type
        /// </summary>
        /// <param name="i_FeatureToLoad">Feature to load</param>
        public void LoadFeature(Type i_FeatureToLoad)
        {
            foreach (Type type in m_Assembly.GetTypes())
            {
                if (type.IsSubclassOf(typeof(FormFb)) && type.IsPublic && type == i_FeatureToLoad)
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new Type[] { });
                    if (constructorInfo != null)
                    {
                        FormFb formToLoad = constructorInfo.Invoke(new object[] { }) as FormFb;
                        if (formToLoad != null)
                        {
                            formToLoad.ShowDialog();
                        }

                        return;
                    }
                }
            }
        }
    }
}
