namespace MeterReading.Permissions
{
    public static class MeterReadingPermissions
    {
        public const string GroupName = "MeterReading";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public class MeterAccount
        {
            public const string Default = GroupName + ".MeterAccount";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
        public class MeterAccountReading
        {
            public const string Default = GroupName + ".MeterAccountReading";
            public const string Update = Default + ".Update";
            // public const string Create = Default + ".Create";
            //  public const string Delete = Default + ".Delete";
        }
    }
}
