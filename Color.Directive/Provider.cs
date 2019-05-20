﻿using System.ComponentModel.Composition;

using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Color.Directive
{
	[Export(typeof(IClassifierProvider))]
	[ContentType("C/C++")]
	internal sealed class ClassifierProvider
		: IClassifierProvider
	{
		// > Field is never assigned
		// Reason The field is assigned by MEF.
		#pragma warning disable 649

		[Import]
		private readonly IClassificationTypeRegistryService ClassificationTypeRegistryService;

        [Import]
        private readonly IClassifierAggregatorService ClassifierAggregatorService;

		#pragma warning restore 649

		private static bool IgnoreRequest;

		public IClassifier GetClassifier(ITextBuffer Buffer)
		{
			if (IgnoreRequest) return null;

			try
			{
				IgnoreRequest = true;

				return Buffer.Properties.GetOrCreateSingletonProperty
				(
					() => new Classifier
					(
						ClassificationTypeRegistryService,
						ClassifierAggregatorService.GetClassifier(Buffer)
					)
				);
			}

			finally
			{
				IgnoreRequest = false;
			}
		}
	}
}