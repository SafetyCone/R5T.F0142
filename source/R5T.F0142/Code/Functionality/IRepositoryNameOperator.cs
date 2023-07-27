using System;

using R5T.T0132;
using R5T.T0184;
using R5T.T0184.Extensions;


namespace R5T.F0142
{
    [FunctionalityMarker]
    public partial interface IRepositoryNameOperator : IFunctionalityMarker
    {
        public IRepositoryName AdjustRepositoryName_ForPrivacy(
            IRepositoryName repositoryName,
            bool isPrivate)
        {
            var output = Instances.NameOperator.Adjust_ForPrivacy(
                repositoryName.Value,
                isPrivate,
                x => x.ToRepositoryName());

            return output;
        }
    }
}
