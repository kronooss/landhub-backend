﻿using System;

namespace Domains.DBModels
{
    public class Properties : BaseEntity
    {

        public string APN { get; set; }
        public string PropertyAddress { get; set; }
        public string PCity { get; set; }
        public string PState { get; set; }
        public string PZip { get; set; }
        public string PZip4 { get; set; }
        public string PUnitNumber { get; set; }
        public string PUnitType { get; set; }
        public string PCarrierRoute { get; set; }
        public string PHouseNumber { get; set; }
        public string PStreetName { get; set; }
        public string PStreetPrefix { get; set; }
        public string PStreetSuffix { get; set; }
        public string PStreetType { get; set; }
        public string CountyName { get; set; }
        public string MailAddress { get; set; }
        public string MCity { get; set; }
        public string MState { get; set; }
        public string MZip { get; set; }
        public string MZip4 { get; set; }
        public string MUnitNumber { get; set; }
        public string MUnitType { get; set; }
        public string OwnerName { get; set; }
        public string OwnerNameFormatted { get; set; }
        public string Owner1FName { get; set; }
        public string Owner1LName { get; set; }
        public string Owner1MName { get; set; }
        public string Owner2FName { get; set; }
        public string Owner2LName { get; set; }
        public string Owner2MName { get; set; }
        public string Transfervalue { get; set; }
        public string LastSaleDate { get; set; }
        public string LastContractDate { get; set; }
        public string LastSaleDocNumber { get; set; }
        public string LastSaleBookNumber { get; set; }
        public string LastSalePageNumber { get; set; }
        public string SaleType { get; set; }
        public string HomeownerExemption { get; set; }
        public string OwnerOccupied { get; set; }
        public string Phone { get; set; }
        public string PropertyType { get; set; }
        public string LandUseDescription { get; set; }
        public string Zoning { get; set; }
        public string Beds { get; set; }
        public string Baths { get; set; }
        public string PartialBaths { get; set; }
        public string BuildingArea { get; set; }
        public string LotArea { get; set; }
        public string LotAreaUnits { get; set; }
        public string NumStories { get; set; }
        public string NumUnits { get; set; }
        public string YearBuilt { get; set; }
        public string Pool { get; set; }
        public string Tract { get; set; }
        public string Block { get; set; }
        public string LotNumber { get; set; }
        public string AreaCode { get; set; }
        public string TaxAmount { get; set; }
        public string Delinquent { get; set; }
        public string TaxRateCodeArea { get; set; }
        public string TaxYear { get; set; }
        public string TotalAssessedValue { get; set; }
        public string AssessedYear { get; set; }
        public string Distress { get; set; }
        public string TBMapGrid { get; set; }
        public string TBMapPage { get; set; }
        public string LandUse { get; set; }
        public string Longitude { get; set; }





        public string PropertyId { get; set; }
        public string OwnerName1Full { get; set; }
        public string OwnerFirstName_MI1 { get; set; }
        public string Owner1Type { get; set; }
        public string Owner1PropertiesOwned { get; set; }
        public string OwnerName2Full { get; set; }
        public string OwnerFirstName_MI2 { get; set; }
        public string Owner2Type { get; set; }
        public string Owner2PropertiesOwned { get; set; }
        public string OwnerName3Full { get; set; }
        public string OwnerName4Full { get; set; }
        public string OwnerStatus { get; set; }
        public string OwnerRightsVestingCode { get; set; }
        public string OwnerEtalVestingCode { get; set; }
        public string OwnerRelationshipType { get; set; }
        public string DoNotMail { get; set; }
        public string MailHouseNumber { get; set; }
        public string MailHouseNumber2 { get; set; }
        public string MailDirection { get; set; }
        public string MailStreetName { get; set; }
        public string MailStreetNameSuffix { get; set; }
        public string MailPostDirection { get; set; }
        public string AlternateMailingCity { get; set; }
        public string MailCarrierRoute { get; set; }
        public string SitusHouseNumber { get; set; }
        public string SitusHouseNumber2 { get; set; }
        public string SitusDirection { get; set; }
        public string SitusPostDirection { get; set; }
        public string SitusUnitNumber { get; set; }
        public string SitusCity { get; set; }
        public string AlternateSitusCity { get; set; }
        public string SitusCarrierCode { get; set; }
        public string APNUnformatted { get; set; }
        public string AlternateAPN { get; set; }
        public string Subdivision { get; set; }
        public string Latitude { get; set; }
        public string Fipscode { get; set; }
        public string Township { get; set; }
        public string Range { get; set; }
        public string Section { get; set; }
        public string Quarter_Section { get; set; }
        public string MunicipalityTownship { get; set; }
        public string CensusTract { get; set; }
        public string CensusBlock { get; set; }
        public string LegalBook { get; set; }
        public string LegalPage { get; set; }
        public string MapRef1 { get; set; }
        public string MapRef2 { get; set; }
        public string NeighborhoodName { get; set; }
        public string ResidentialNeighborhoodName { get; set; }
        public string SubNeighborhoodName { get; set; }
        public string MacroNeighborhoodName { get; set; }
        public string SchoolDistrict1 { get; set; }
        public string SchoolDistrict2 { get; set; }
        public string SchoolDistrict3 { get; set; }
        public string ElementarySchool { get; set; }
        public string HighSchool { get; set; }
        public string MiddleSchool { get; set; }
        public string StateUse { get; set; }
        public string CountyLandUse { get; set; }
        public string SiteInfluence { get; set; }
        public string ViewQuality { get; set; }
        public string NumberOfBuildings { get; set; }
        public string NumberOfResUnits { get; set; }
        public string NumberOfbusCommUnits { get; set; }
        public string UsableLot { get; set; }
        public string UsableLotSize { get; set; }
        public string LotShape { get; set; }
        public string LandSquareFootage { get; set; }
        public string FrontFootage { get; set; }
        public string DepthFootage { get; set; }
        public string LegalBlock { get; set; }
        public string WaterType { get; set; }
        public string SewerType { get; set; }
        public string FloodZoneCode { get; set; }
        public string FloodMap { get; set; }
        public string FloodMapDate { get; set; }
        public string FloodPanel { get; set; }
        public string CommunityName { get; set; }
        public string InsideSFHA { get; set; }
        public string SumOfAboveLivingSquareFootage { get; set; }
        public string BuildingAreaSqft { get; set; }
        public string GrossLivingArea { get; set; }
        public string SumOfAdjustedGrossSquareFeet { get; set; }
        public string SumOfGroundFloorSquareFeet { get; set; }
        public string AdditionsSquareFeet { get; set; }
        public string SumOfbasementSquareFeet { get; set; }
        public string SumOfTotalRooms { get; set; }
        public string SumOfBedRooms { get; set; }
        public string FullBaths { get; set; }
        public string BathroomsNew { get; set; }
        public string HalfBaths { get; set; }
        public string BathFixtures { get; set; }
        public string NumberOfDiningRooms { get; set; }
        public string NumberOfFamilyRooms { get; set; }
        public string NumberOfOtherRooms { get; set; }
        public string YearBuiltEffective { get; set; }
        public string FireplaceIndicator { get; set; }
        public string FirePlaceNumber { get; set; }
        public string StoriesNumber { get; set; }
        public string StoriesDescription { get; set; }
        public string GarageType { get; set; }
        public string ParkingType { get; set; }
        public string GarageArea { get; set; }
        public string ParkingSpaces { get; set; }
        public string BasementType { get; set; }
        public string BasementArea { get; set; }
        public string FloorType { get; set; }
        public string RoofType { get; set; }
        public string RoofMaterialType { get; set; }
        public string RoofFrame { get; set; }
        public string Foundation { get; set; }
        public string ConstructionType { get; set; }
        public string ExteriorWall { get; set; }
        public string Frame { get; set; }
        public string PorchType { get; set; }
        public string PorchSquareFootage { get; set; }
        public string PatioType { get; set; }
        public string PatioSquareFootage { get; set; }
        public string PoolSquareFootage { get; set; }
        public string AirConditioning { get; set; }
        public string HeatType { get; set; }
        public string HeatFuel { get; set; }
        public string Electric { get; set; }
        public string Style { get; set; }
        public string Quality { get; set; }
        public string Condition { get; set; }
        public string TotalValueTaxable { get; set; }
        public string PropertyTax { get; set; }
        public string TaxArea { get; set; }
        public string AppraisalDistrict { get; set; }
        public string ExemptDisabled { get; set; }
        public string ExemptHomestead { get; set; }
        public string WelfareExemption { get; set; }
        public string CemetaryExemption { get; set; }
        public string HospitalExemption { get; set; }
        public string LibraryExemption { get; set; }
        public string MuseumExemption { get; set; }
        public string ExemptReligious { get; set; }
        public string ExemptSchool { get; set; }
        public string ExemptSenior { get; set; }
        public string ExemptUtilities { get; set; }
        public string ExemptVeteran { get; set; }
        public string ExemptWidow { get; set; }
        public string DelinquentTaxYear { get; set; }
        public string DelinquentTaxValue { get; set; }
        public string AssdTotalValue { get; set; }
        public string AssdLandValue { get; set; }
        public string AssdImprovementValue { get; set; }
        public string AssdImprovementPercentage { get; set; }
        public string MarketValue { get; set; }
        public string MktTotalValue { get; set; }
        public string MktLandValue { get; set; }
        public string MktImprovementValue { get; set; }
        public string MktImprovementPercentage { get; set; }
        public string ApprTotalValue { get; set; }
        public string ApprLandValue { get; set; }
        public string ApprImprovementValue { get; set; }
        public string ApprImprovementPercentage { get; set; }
        public string EstimatedValue { get; set; }
        public string HomeEquityPercentage { get; set; }
        public string HomeEquityValue { get; set; }
        public string OpportunityZone { get; set; }
        public string OTDeedType { get; set; }
        public string OTSaleDate { get; set; }
        public string OTRecordingDate { get; set; }
        public string OTSalePrice { get; set; }
        public string OTDocumentNumber { get; set; }
        public string OTDocumentBookPage { get; set; }
        public string OT1stMtgDocumentNo { get; set; }
        public string LMSDeedType { get; set; }
        public string LMSSaleDate { get; set; }
        public string LMSRecordingDate { get; set; }
        public string LMSSalePrice { get; set; }
        public string LMSSaleType { get; set; }
        public string LMSDocumentNumber { get; set; }
        public string LMSDocumentBookPage { get; set; }
        public string LMSMultiSplitSale { get; set; }
        public string LMSSellerName { get; set; }
        public string LMSPriceperSqFt { get; set; }
        public string LMSFirstMtgAmount { get; set; }
        public string LMSFirstMtgType { get; set; }
        public string LMSFirstMtgIntRate { get; set; }
        public string LMSFirstMtgIntRateType { get; set; }
        public string LMSFirstMtgDocumentNo { get; set; }
        public string LMSNewConstruction { get; set; }
        public string LMSLender { get; set; }
        public string LMSTitleCompany { get; set; }
        public string LMSSecondMtgAmount { get; set; }
        public string LMSSecondMtgType { get; set; }
        public string LMSSecondMtgIntRate { get; set; }
        public string LMSSecondMtgIntRateType { get; set; }
        public string LMSSecondMtgDocumentNo { get; set; }
        public string LMSPriorDeedType { get; set; }
        public string LMSPriorSaleDate { get; set; }
        public string LMSPriorRecDate { get; set; }
        public string LMSPriorSalePrice { get; set; }
        public string LMSPrior1stMtgAmount { get; set; }
        public string LMSPrior1stMtgType { get; set; }
        public string LMSPrior1stMtgRate { get; set; }
        public string LMSPrior1stMtgRateType { get; set; }
        public string LMSPriorLender { get; set; }
        public string LMSPriorDocNumber { get; set; }
        public string LMSPriorDocBookPage { get; set; }
        public string Reference { get; set; }
        public string Filtered_Out { get; set; }

















        public string OrgId { get; set; }
        public DateTime ImportedTime { get; set; }
        public string UserId { get; set; }
        public string ImportFileId { get; set; }
        public string CampaignStatus { get; set; }
    }
}
