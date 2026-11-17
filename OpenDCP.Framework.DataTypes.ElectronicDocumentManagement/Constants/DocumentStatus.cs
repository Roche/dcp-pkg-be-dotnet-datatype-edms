namespace OpenDCP.Framework.DataTypes.ElectronicDocumentManagement.Constants
{
    public enum DocumentStatus : byte
    {
        /// <summary>
        /// Document is initialy created
        /// </summary>
        Draft = 1,
        /// <summary>
        /// Document is produced by R and downloaded WITHOUT send to Condor
        /// </summary>
        Approved = 2,
        /// <summary>
        /// Document is approved into Condor
        /// </summary>
        Effective = 3,
        /// <summary>
        /// we have to perform a request to Condor and see if there is a documnet into Condor which is in Withdraw state. 
        ///If yes its mean that in DCP is also in Withdraw status.
        /// </summary>
        Withdraw = 4
    }
}
