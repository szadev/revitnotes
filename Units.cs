public static class Units
	{
		private static List<string> unitsWhenDouble = new List<string> { "autodesk.spec.aec:massDensity-2.0.0", "autodesk.spec.measurable:currency-2.0.0", "autodesk.spec.aec:slope-2.0.0",
																		"autodesk.spec.aec:area-2.0.0", "autodesk.spec.aec:costPerArea-2.0.0", "autodesk.spec.aec:angle-2.0.0",
																		"autodesk.spec.aec:time-2.0.0", "autodesk.spec.aec:distance-2.0.0", "autodesk.spec.aec:length-2.0.0",
																		"autodesk.spec.aec:volume-2.0.0", "autodesk.spec.aec:number-2.0.0", "autodesk.spec.aec:rotationAngle-2.0.0",
																		"autodesk.spec.aec:speed-2.0.0"
																		};
		private static List<string> unitsWhenInteger = new List<string> { "autodesk.spec:spec.bool-1.0.0", "autodesk.spec:spec.int64-2.0.0" };
		private static List<string> unitsWhenElementId = new List<string> { "autodesk.spec.reference:image-1.0.0", "autodesk.spec.aec:material-1.0.0" };
		private static List<string> unitsWhenString = new List<string> { "autodesk.spec.aec:multilineText-2.0.0", "autodesk.spec:spec.string-2.0.0", "autodesk.spec.string:url-2.0.0"};

        public static StorageType GetStorageTypeFromForgeTypeId(ForgeTypeId typeId)
		{
			string ForgeTypeId = typeId.TypeId;
			StorageType storageType = StorageType.None;
			if (unitsWhenDouble.Contains(ForgeTypeId)) return StorageType.Double;
			else if (ForgeTypeId.Contains("bool") || unitsWhenInteger.Contains(ForgeTypeId)) return StorageType.Integer;
			else if (ForgeTypeId.Contains("category") || ForgeTypeId.Contains("image") || ForgeTypeId.Contains("material") || unitsWhenElementId.Contains(ForgeTypeId)) return StorageType.ElementId;
			else if (ForgeTypeId.Contains("string") || unitsWhenString.Contains(ForgeTypeId)) return StorageType.String;
			else return storageType;
		}
	}
