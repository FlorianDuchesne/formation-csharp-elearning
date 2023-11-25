using System;
namespace HarryPotter.Games.Core
{
    public class ForceNeutre : Force
    {
        #region constructors
        public ForceNeutre() : base("Force neutre")
        {
            this.Id = 3;
        }
        #endregion
    }
}
