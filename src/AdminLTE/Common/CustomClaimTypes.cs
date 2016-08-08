namespace AdminLTE.Common
{
    public static class CustomClaimTypes
    {
        #region Default ClaimTypes (taken from ClaimTypes class)
        //
        // Summary:
        //     http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor.
        public const string Actor = "http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor";
        //
        // Summary:
        //     The URI for a claim that specifies the anonymous user; http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous.
        public const string Anonymous = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous";
        //
        // Summary:
        //     The URI for a claim that specifies details about whether an identity is authenticated,
        //     http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated.
        public const string Authentication = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authentication";
        //
        // Summary:
        //     The URI for a claim that specifies the instant at which an entity was authenticated;
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant.
        public const string AuthenticationInstant = "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant";
        //
        // Summary:
        //     The URI for a claim that specifies the method with which an entity was authenticated;
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod.
        public const string AuthenticationMethod = "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod";
        //
        // Summary:
        //     The URI for a claim that specifies an authorization decision on an entity; http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision.
        public const string AuthorizationDecision = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision";
        //
        // Summary:
        //     The URI for a claim that specifies the cookie path; http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath.
        public const string CookiePath = "http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath";
        //
        // Summary:
        //     The URI for a claim that specifies the country/region in which an entity resides,
        //     http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country.
        public const string Country = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country";
        //
        // Summary:
        //     The URI for a claim that specifies the date of birth of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth.
        public const string DateOfBirth = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth";
        //
        // Summary:
        //     The URI for a claim that specifies the deny-only primary group SID on an entity;
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid.
        //     A deny-only SID denies the specified entity to a securable object.
        public const string DenyOnlyPrimaryGroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid";
        //
        // Summary:
        //     The URI for a claim that specifies the deny-only primary SID on an entity; http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid.
        //     A deny-only SID denies the specified entity to a securable object.
        public const string DenyOnlyPrimarySid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid";
        //
        // Summary:
        //     The URI for a claim that specifies a deny-only security identifier (SID) for
        //     an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid.
        //     A deny-only SID denies the specified entity to a securable object.
        public const string DenyOnlySid = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup.
        public const string DenyOnlyWindowsDeviceGroup = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup";
        //
        // Summary:
        //     The URI for a claim that specifies the DNS name associated with the computer
        //     name or with the alternative name of either the subject or issuer of an X.509
        //     certificate, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns.
        public const string Dns = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa.
        public const string Dsa = "http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa";
        //
        // Summary:
        //     The URI for a claim that specifies the email address of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/email.
        public const string Email = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration.
        public const string Expiration = "http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/expired.
        public const string Expired = "http://schemas.microsoft.com/ws/2008/06/identity/claims/expired";
        //
        // Summary:
        //     The URI for a claim that specifies the gender of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender.
        public const string Gender = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender";
        //
        // Summary:
        //     The URI for a claim that specifies the given name of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname.
        public const string GivenName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname";
        //
        // Summary:
        //     The URI for a claim that specifies the SID for the group of an entity, http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid.
        public const string GroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid";
        //
        // Summary:
        //     The URI for a claim that specifies a hash value, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash.
        public const string Hash = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash";
        //
        // Summary:
        //     The URI for a claim that specifies the home phone number of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone.
        public const string HomePhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent.
        public const string IsPersistent = "http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent";
        //
        // Summary:
        //     The URI for a claim that specifies the locale in which an entity resides, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality.
        public const string Locality = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality";
        //
        // Summary:
        //     The URI for a claim that specifies the mobile phone number of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone.
        public const string MobilePhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone";
        //
        // Summary:
        //     The URI for a claim that specifies the name of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name.
        public const string Name = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
        //
        // Summary:
        //     The URI for a claim that specifies the name of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier.
        public const string NameIdentifier = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier";
        //
        // Summary:
        //     The URI for a claim that specifies the alternative phone number of an entity,
        //     http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone.
        public const string OtherPhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone";
        //
        // Summary:
        //     The URI for a claim that specifies the postal code of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode.
        public const string PostalCode = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode";
        //
        // Summary:
        //     The URI for a claim that specifies the primary group SID of an entity, http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid.
        public const string PrimaryGroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid";
        //
        // Summary:
        //     The URI for a claim that specifies the primary SID of an entity, http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid.
        public const string PrimarySid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid";
        //
        // Summary:
        //     The URI for a claim that specifies the role of an entity, http://schemas.microsoft.com/ws/2008/06/identity/claims/role.
        public const string Role = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
        //
        // Summary:
        //     The URI for a claim that specifies an RSA key, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa.
        public const string Rsa = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa";
        //
        // Summary:
        //     The URI for a claim that specifies a serial number, http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber.
        public const string SerialNumber = "http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber";
        //
        // Summary:
        //     The URI for a claim that specifies a security identifier (SID), http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid.
        public const string Sid = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid";
        //
        // Summary:
        //     The URI for a claim that specifies a service principal name (SPN) claim, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn.
        public const string Spn = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn";
        //
        // Summary:
        //     The URI for a claim that specifies the state or province in which an entity resides,
        //     http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince.
        public const string StateOrProvince = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince";
        //
        // Summary:
        //     The URI for a claim that specifies the street address of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress.
        public const string StreetAddress = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress";
        //
        // Summary:
        //     The URI for a claim that specifies the surname of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname.
        public const string Surname = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname";
        //
        // Summary:
        //     The URI for a claim that identifies the system entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system.
        public const string System = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system";
        //
        // Summary:
        //     The URI for a claim that specifies a thumbprint, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint.
        //     A thumbprint is a globally unique SHA-1 hash of an X.509 certificate.
        public const string Thumbprint = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint";
        //
        // Summary:
        //     The URI for a claim that specifies a user principal name (UPN), http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn.
        public const string Upn = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn";
        //
        // Summary:
        //     The URI for a claim that specifies a URI, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri.
        public const string Uri = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata.
        public const string UserData = "http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/version.
        public const string Version = "http://schemas.microsoft.com/ws/2008/06/identity/claims/version";
        //
        // Summary:
        //     The URI for a claim that specifies the webpage of an entity, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage.
        public const string Webpage = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage";
        //
        // Summary:
        //     The URI for a claim that specifies the Windows domain account name of an entity,
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname.
        public const string WindowsAccountName = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim.
        public const string WindowsDeviceClaim = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup.
        public const string WindowsDeviceGroup = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion.
        public const string WindowsFqbnVersion = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority.
        public const string WindowsSubAuthority = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority";
        //
        // Summary:
        //     http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim.
        public const string WindowsUserClaim = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim";
        //
        // Summary:
        //     The URI for a distinguished name claim of an X.509 certificate, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname.
        //     The X.500 standard defines the methodology for defining distinguished names that
        //     are used by X.509 certificates.
        public const string X500DistinguishedName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname";

        #endregion

        public const string AvatarURL = "http://schemas.xmlsoap.org/ws/2009/09/identity/claims/avatarurl";
        public const string Position = "http://schemas.xmlsoap.org/ws/2009/09/identity/claims/position";
        public const string NickName = "http://schemas.xmlsoap.org/ws/2009/09/identity/claims/nickname";
        public const string DateRegistered = "http://schemas.xmlsoap.org/ws/2009/09/identity/claims/dateregistered";

    }
}
