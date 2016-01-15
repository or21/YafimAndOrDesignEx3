//-----------------------------------------------------------------------
// <copyright file="FeatureBuilder.cs" company="A16_Ex03">
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
    public class FeatureBuilder
    {
        /// <summary>
        /// The current project assembly
        /// </summary>
        private Assembly m_Assembly;

        public FeatureBuilder(Assembly i_Assembly)
        {
            m_Assembly = i_Assembly;
        }

        /// <summary>
        /// Loads feature according to type
        /// </summary>
        /// <param name="i_FeatureToLoad">Feature to load</param>
        /// <param name="i_Compare">Compare photos</param>
        public void LoadFeature(Type i_FeatureToLoad, ICompare i_Compare)
        {
            foreach (Type type in m_Assembly.GetTypes())
            {
                if (type.IsSubclassOf(typeof(FormFb)) && type.IsPublic && type == i_FeatureToLoad)
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new Type[] { typeof(ICompare) });
                    if (constructorInfo != null)
                    {
                        FormFb formToLoad = constructorInfo.Invoke(new object[] { i_Compare }) as FormFb;
                        if (formToLoad != null)
                        {
                            if (i_Compare != null)
                            {
                                formToLoad.Compare = i_Compare;
                            }

                            formToLoad.ShowDialog();
                        }

                        return;
                    }
                }
            }
        }
    }
}
