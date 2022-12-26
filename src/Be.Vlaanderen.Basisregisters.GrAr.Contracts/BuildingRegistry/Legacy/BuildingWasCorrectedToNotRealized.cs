namespace Be.Vlaanderen.Basisregisters.GrAr.Contracts.BuildingRegistry
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Common;

    public class BuildingWasCorrectedToNotRealized : IQueueMessage
    {
        public string BuildingId { get; }
        public List<string> BuildingUnitIdsToRetire { get; }
        public List<string> BuildingUnitIdsToNotRealize { get; }
        public Provenance Provenance { get; }

        public BuildingWasCorrectedToNotRealized(
            string buildingId,
            IEnumerable<string> buildingUnitIdsToRetire,
            IEnumerable<string> buildingUnitIdsToNotRealize,
            Provenance provenance)
        {
            BuildingId = buildingId;
            BuildingUnitIdsToRetire = buildingUnitIdsToRetire.ToList();
            BuildingUnitIdsToNotRealize = buildingUnitIdsToNotRealize.ToList();
            Provenance = provenance;
        }
    }
}