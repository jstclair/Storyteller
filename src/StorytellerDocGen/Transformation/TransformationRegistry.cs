﻿using StructureMap;

namespace StorytellerDocGen.Transformation
{
    public class TransformationRegistry : Registry
    {
        public TransformationRegistry()
        {
            For<ITransformer>().Use<Transformer>();
            ForSingletonOf<IHtmlGenerator>().Use<HtmlGenerator>();

            Scan(_ =>
            {
                _.TheCallingAssembly();
                _.AddAllTypesOf<ITransformHandler>();
            });
        }
    }
}