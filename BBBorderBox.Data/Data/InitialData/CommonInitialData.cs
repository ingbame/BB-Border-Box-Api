using BBBorderBox.Entity.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BBBorderBox.Data.Data.InitialData
{
    public class CommonInitialData
    {
        private readonly BBBorderBoxContext _context;
        #region Patron de Diseño
        private static CommonInitialData _instance;
        private static readonly object _instanceLock = new object();
        public static CommonInitialData Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                            _instance = new CommonInitialData();
                    }
                }
                return _instance;
            }
        }
        private CommonInitialData() : this(new BBBorderBoxContext(new DbContextOptions<BBBorderBoxContext>()))
        {

        }
        private CommonInitialData(BBBorderBoxContext context)
        {
            _context = context;
        }
        #endregion
        #region Public Methods
        public List<User> AddUsers()
        {
            List<User> users = new List<User> {
            new User { UserId = 1, UserName = "superadmin", SaltPswd = "", Password = "bbborderbox" },
            new User { UserId = 2, UserName = "testadmin", SaltPswd = "", Password = "bbborderbox" }
            };
            return users;
        }
        public Country[] AddCountries()
        {
            List<Country> countries = new List<Country> {
                new Country { StrKey = "AD", CountryName = "NDORRA", IsActive = false},
                new Country { StrKey = "AE", CountryName = "NITED ARAB EMIRATES", IsActive = false},
                new Country { StrKey = "AF", CountryName = "FGHANISTAN", IsActive = false},
                new Country { StrKey = "AG", CountryName = "NTIGUA AND BARBUDA", IsActive = false},
                new Country { StrKey = "AI", CountryName = "NGUILLA", IsActive = false},
                new Country { StrKey = "AL", CountryName = "LBANIA", IsActive = false},
                new Country { StrKey = "AM", CountryName = "RMENIA", IsActive = false},
                new Country { StrKey = "AO", CountryName = "NGOLA", IsActive = false},
                new Country { StrKey = "AQ", CountryName = "NTARCTICA", IsActive = false},
                new Country { StrKey = "AR", CountryName = "RGENTINA", IsActive = false},
                new Country { StrKey = "AS", CountryName = "MERICAN SAMOA", IsActive = false},
                new Country { StrKey = "AT", CountryName = "USTRIA", IsActive = false},
                new Country { StrKey = "AU", CountryName = "USTRALIA", IsActive = false},
                new Country { StrKey = "AW", CountryName = "RUBA", IsActive = false},
                new Country { StrKey = "AX", CountryName = "LAND ISLANDS", IsActive = false},
                new Country { StrKey = "AZ", CountryName = "ZERBAIJAN", IsActive = false},
                new Country { StrKey = "BA", CountryName = "OSNIA AND HERZEGOVINA", IsActive = false},
                new Country { StrKey = "BB", CountryName = "ARBADOS", IsActive = false},
                new Country { StrKey = "BD", CountryName = "ANGLADESH", IsActive = false},
                new Country { StrKey = "BE", CountryName = "ELGIUM", IsActive = false},
                new Country { StrKey = "BF", CountryName = "URKINA FASO", IsActive = false},
                new Country { StrKey = "BG", CountryName = "ULGARIA", IsActive = false},
                new Country { StrKey = "BH", CountryName = "AHRAIN", IsActive = false},
                new Country { StrKey = "BI", CountryName = "URUNDI", IsActive = false},
                new Country { StrKey = "BJ", CountryName = "ENIN", IsActive = false},
                new Country { StrKey = "BL", CountryName = "AINT BARTHÉLEMY", IsActive = false},
                new Country { StrKey = "BM", CountryName = "ERMUDA", IsActive = false},
                new Country { StrKey = "BN", CountryName = "RUNEI DARUSSALAM", IsActive = false},
                new Country { StrKey = "BO", CountryName = "OLIVIA (PLURINATIONAL STATE OF)", IsActive = false},
                new Country { StrKey = "BQ", CountryName = "ONAIRE, SINT EUSTATIUS AND SABA", IsActive = false},
                new Country { StrKey = "BR", CountryName = "RAZIL", IsActive = false},
                new Country { StrKey = "BS", CountryName = "AHAMAS", IsActive = false},
                new Country { StrKey = "BT", CountryName = "HUTAN", IsActive = false},
                new Country { StrKey = "BV", CountryName = "OUVET ISLAND", IsActive = false},
                new Country { StrKey = "BW", CountryName = "OTSWANA", IsActive = false},
                new Country { StrKey = "BY", CountryName = "ELARUS", IsActive = false},
                new Country { StrKey = "BZ", CountryName = "ELIZE", IsActive = false},
                new Country { StrKey = "CA", CountryName = "ANADA", IsActive = false},
                new Country { StrKey = "CC", CountryName = "OCOS (KEELING) ISLANDS", IsActive = false},
                new Country { StrKey = "CD", CountryName = "ONGO, DEMOCRATIC REPUBLIC OF THE", IsActive = false},
                new Country { StrKey = "CF", CountryName = "ENTRAL AFRICAN REPUBLIC", IsActive = false},
                new Country { StrKey = "CG", CountryName = "ONGO", IsActive = false},
                new Country { StrKey = "CH", CountryName = "WITZERLAND", IsActive = false},
                new Country { StrKey = "CI", CountryName = "ÔTE D''IVOIRE", IsActive = false},
                new Country { StrKey = "CK", CountryName = "COOK ISLANDS", IsActive = false},
                new Country { StrKey = "CL", CountryName = "CHILE", IsActive = false},
                new Country { StrKey = "CM", CountryName = "CAMEROON", IsActive = false},
                new Country { StrKey = "CN", CountryName = "CHINA", IsActive = false},
                new Country { StrKey = "CO", CountryName = "COLOMBIA", IsActive = false},
                new Country { StrKey = "CR", CountryName = "COSTA RICA", IsActive = false},
                new Country { StrKey = "CU", CountryName = "CUBA", IsActive = false},
                new Country { StrKey = "CV", CountryName = "CABO VERDE", IsActive = false},
                new Country { StrKey = "CW", CountryName = "CURAÇAO", IsActive = false},
                new Country { StrKey = "CX", CountryName = "CHRISTMAS ISLAND", IsActive = false},
                new Country { StrKey = "CY", CountryName = "CYPRUS", IsActive = false},
                new Country { StrKey = "CZ", CountryName = "CZECHIA", IsActive = false},
                new Country { StrKey = "DE", CountryName = "GERMANY", IsActive = false},
                new Country { StrKey = "DJ", CountryName = "DJIBOUTI", IsActive = false},
                new Country { StrKey = "DK", CountryName = "DENMARK", IsActive = false},
                new Country { StrKey = "DM", CountryName = "DOMINICA", IsActive = false},
                new Country { StrKey = "DO", CountryName = "DOMINICAN REPUBLIC", IsActive = false},
                new Country { StrKey = "DZ", CountryName = "ALGERIA", IsActive = false},
                new Country { StrKey = "EC", CountryName = "ECUADOR", IsActive = false},
                new Country { StrKey = "EE", CountryName = "ESTONIA", IsActive = false},
                new Country { StrKey = "EG", CountryName = "EGYPT", IsActive = false},
                new Country { StrKey = "EH", CountryName = "WESTERN SAHARA", IsActive = false},
                new Country { StrKey = "ER", CountryName = "ERITREA", IsActive = false},
                new Country { StrKey = "ES", CountryName = "SPAIN", IsActive = false},
                new Country { StrKey = "ET", CountryName = "ETHIOPIA", IsActive = false},
                new Country { StrKey = "FI", CountryName = "FINLAND", IsActive = false},
                new Country { StrKey = "FJ", CountryName = "FIJI", IsActive = false},
                new Country { StrKey = "FK", CountryName = "FALKLAND ISLANDS (MALVINAS)", IsActive = false},
                new Country { StrKey = "FM", CountryName = "MICRONESIA (FEDERATED STATES OF)", IsActive = false},
                new Country { StrKey = "FO", CountryName = "FAROE ISLANDS", IsActive = false},
                new Country { StrKey = "FR", CountryName = "FRANCE", IsActive = false},
                new Country { StrKey = "GA", CountryName = "GABON", IsActive = false},
                new Country { StrKey = "GB", CountryName = "UNITED KINGDOM OF GREAT BRITAIN AND NORTHERN IRELAND", IsActive = false},
                new Country { StrKey = "GD", CountryName = "GRENADA", IsActive = false},
                new Country { StrKey = "GE", CountryName = "GEORGIA", IsActive = false},
                new Country { StrKey = "GF", CountryName = "FRENCH GUIANA", IsActive = false},
                new Country { StrKey = "GG", CountryName = "GUERNSEY", IsActive = false},
                new Country { StrKey = "GH", CountryName = "GHANA", IsActive = false},
                new Country { StrKey = "GI", CountryName = "GIBRALTAR", IsActive = false},
                new Country { StrKey = "GL", CountryName = "GREENLAND", IsActive = false},
                new Country { StrKey = "GM", CountryName = "GAMBIA", IsActive = false},
                new Country { StrKey = "GN", CountryName = "GUINEA", IsActive = false},
                new Country { StrKey = "GP", CountryName = "GUADELOUPE", IsActive = false},
                new Country { StrKey = "GQ", CountryName = "EQUATORIAL GUINEA", IsActive = false},
                new Country { StrKey = "GR", CountryName = "GREECE", IsActive = false},
                new Country { StrKey = "GS", CountryName = "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", IsActive = false},
                new Country { StrKey = "GT", CountryName = "GUATEMALA", IsActive = false},
                new Country { StrKey = "GU", CountryName = "GUAM", IsActive = false},
                new Country { StrKey = "GW", CountryName = "GUINEA-BISSAU", IsActive = false},
                new Country { StrKey = "GY", CountryName = "GUYANA", IsActive = false},
                new Country { StrKey = "HK", CountryName = "HONG KONG", IsActive = false},
                new Country { StrKey = "HM", CountryName = "HEARD ISLAND AND MCDONALD ISLANDS", IsActive = false},
                new Country { StrKey = "HN", CountryName = "HONDURAS", IsActive = false},
                new Country { StrKey = "HR", CountryName = "CROATIA", IsActive = false},
                new Country { StrKey = "HT", CountryName = "HAITI", IsActive = false},
                new Country { StrKey = "HU", CountryName = "HUNGARY", IsActive = false},
                new Country { StrKey = "ID", CountryName = "INDONESIA", IsActive = false},
                new Country { StrKey = "IE", CountryName = "IRELAND", IsActive = false},
                new Country { StrKey = "IL", CountryName = "ISRAEL", IsActive = false},
                new Country { StrKey = "IM", CountryName = "ISLE OF MAN", IsActive = false},
                new Country { StrKey = "IN", CountryName = "INDIA", IsActive = false},
                new Country { StrKey = "IO", CountryName = "BRITISH INDIAN OCEAN TERRITORY", IsActive = false},
                new Country { StrKey = "IQ", CountryName = "IRAQ", IsActive = false},
                new Country { StrKey = "IR", CountryName = "IRAN (ISLAMIC REPUBLIC OF)", IsActive = false},
                new Country { StrKey = "IS", CountryName = "ICELAND", IsActive = false},
                new Country { StrKey = "IT", CountryName = "ITALY", IsActive = false},
                new Country { StrKey = "JE", CountryName = "JERSEY", IsActive = false},
                new Country { StrKey = "JM", CountryName = "JAMAICA", IsActive = false},
                new Country { StrKey = "JO", CountryName = "JORDAN", IsActive = false},
                new Country { StrKey = "JP", CountryName = "JAPAN", IsActive = false},
                new Country { StrKey = "KE", CountryName = "KENYA", IsActive = false},
                new Country { StrKey = "KG", CountryName = "KYRGYZSTAN", IsActive = false},
                new Country { StrKey = "KH", CountryName = "CAMBODIA", IsActive = false},
                new Country { StrKey = "KI", CountryName = "KIRIBATI", IsActive = false},
                new Country { StrKey = "KM", CountryName = "COMOROS", IsActive = false},
                new Country { StrKey = "KN", CountryName = "SAINT KITTS AND NEVIS", IsActive = false},
                new Country { StrKey = "KP", CountryName = "KOREA (DEMOCRATIC PEOPLE''S REPUBLIC OF)", IsActive = false},
                new Country { StrKey = "KR", CountryName = "KOREA, REPUBLIC OF", IsActive = false},
                new Country { StrKey = "KW", CountryName = "KUWAIT", IsActive = false},
                new Country { StrKey = "KY", CountryName = "CAYMAN ISLANDS", IsActive = false},
                new Country { StrKey = "KZ", CountryName = "KAZAKHSTAN", IsActive = false},
                new Country { StrKey = "LA", CountryName = "LAO PEOPLE''S DEMOCRATIC REPUBLIC", IsActive = false},
                new Country { StrKey = "LB", CountryName = "LEBANON", IsActive = false},
                new Country { StrKey = "LC", CountryName = "SAINT LUCIA", IsActive = false},
                new Country { StrKey = "LI", CountryName = "LIECHTENSTEIN", IsActive = false},
                new Country { StrKey = "LK", CountryName = "SRI LANKA", IsActive = false},
                new Country { StrKey = "LR", CountryName = "LIBERIA", IsActive = false},
                new Country { StrKey = "LS", CountryName = "LESOTHO", IsActive = false},
                new Country { StrKey = "LT", CountryName = "LITHUANIA", IsActive = false},
                new Country { StrKey = "LU", CountryName = "LUXEMBOURG", IsActive = false},
                new Country { StrKey = "LV", CountryName = "LATVIA", IsActive = false},
                new Country { StrKey = "LY", CountryName = "LIBYA", IsActive = false},
                new Country { StrKey = "MA", CountryName = "MOROCCO", IsActive = false},
                new Country { StrKey = "MC", CountryName = "MONACO", IsActive = false},
                new Country { StrKey = "MD", CountryName = "MOLDOVA, REPUBLIC OF", IsActive = false},
                new Country { StrKey = "ME", CountryName = "MONTENEGRO", IsActive = false},
                new Country { StrKey = "MF", CountryName = "SAINT MARTIN (FRENCH PART)", IsActive = false},
                new Country { StrKey = "MG", CountryName = "MADAGASCAR", IsActive = false},
                new Country { StrKey = "MH", CountryName = "MARSHALL ISLANDS", IsActive = false},
                new Country { StrKey = "MK", CountryName = "NORTH MACEDONIA", IsActive = false},
                new Country { StrKey = "ML", CountryName = "MALI", IsActive = false},
                new Country { StrKey = "MM", CountryName = "MYANMAR", IsActive = false},
                new Country { StrKey = "MN", CountryName = "MONGOLIA", IsActive = false},
                new Country { StrKey = "MO", CountryName = "MACAO", IsActive = false},
                new Country { StrKey = "MP", CountryName = "NORTHERN MARIANA ISLANDS", IsActive = false},
                new Country { StrKey = "MQ", CountryName = "MARTINIQUE", IsActive = false},
                new Country { StrKey = "MR", CountryName = "MAURITANIA", IsActive = false},
                new Country { StrKey = "MS", CountryName = "MONTSERRAT", IsActive = false},
                new Country { StrKey = "MT", CountryName = "MALTA", IsActive = false},
                new Country { StrKey = "MU", CountryName = "MAURITIUS", IsActive = false},
                new Country { StrKey = "MV", CountryName = "MALDIVES", IsActive = false},
                new Country { StrKey = "MW", CountryName = "MALAWI", IsActive = false},
                new Country { StrKey = "MX", CountryName = "MEXICO", IsActive = true},
                new Country { StrKey = "MY", CountryName = "MALAYSIA", IsActive = false},
                new Country { StrKey = "MZ", CountryName = "MOZAMBIQUE", IsActive = false},
                new Country { StrKey = "NA", CountryName = "NAMIBIA", IsActive = false},
                new Country { StrKey = "NC", CountryName = "NEW CALEDONIA", IsActive = false},
                new Country { StrKey = "NE", CountryName = "NIGER", IsActive = false},
                new Country { StrKey = "NF", CountryName = "NORFOLK ISLAND", IsActive = false},
                new Country { StrKey = "NG", CountryName = "NIGERIA", IsActive = false},
                new Country { StrKey = "NI", CountryName = "NICARAGUA", IsActive = false},
                new Country { StrKey = "NL", CountryName = "NETHERLANDS", IsActive = false},
                new Country { StrKey = "NO", CountryName = "NORWAY", IsActive = false},
                new Country { StrKey = "NP", CountryName = "NEPAL", IsActive = false},
                new Country { StrKey = "NR", CountryName = "NAURU", IsActive = false},
                new Country { StrKey = "NU", CountryName = "NIUE", IsActive = false},
                new Country { StrKey = "NZ", CountryName = "NEW ZEALAND", IsActive = false},
                new Country { StrKey = "OM", CountryName = "OMAN", IsActive = false},
                new Country { StrKey = "PA", CountryName = "PANAMA", IsActive = false},
                new Country { StrKey = "PE", CountryName = "PERU", IsActive = false},
                new Country { StrKey = "PF", CountryName = "FRENCH POLYNESIA", IsActive = false},
                new Country { StrKey = "PG", CountryName = "PAPUA NEW GUINEA", IsActive = false},
                new Country { StrKey = "PH", CountryName = "PHILIPPINES", IsActive = false},
                new Country { StrKey = "PK", CountryName = "PAKISTAN", IsActive = false},
                new Country { StrKey = "PL", CountryName = "POLAND", IsActive = false},
                new Country { StrKey = "PM", CountryName = "SAINT PIERRE AND MIQUELON", IsActive = false},
                new Country { StrKey = "PN", CountryName = "PITCAIRN", IsActive = false},
                new Country { StrKey = "PR", CountryName = "PUERTO RICO", IsActive = false},
                new Country { StrKey = "PS", CountryName = "PALESTINE, STATE OF", IsActive = false},
                new Country { StrKey = "PT", CountryName = "PORTUGAL", IsActive = false},
                new Country { StrKey = "PW", CountryName = "PALAU", IsActive = false},
                new Country { StrKey = "PY", CountryName = "PARAGUAY", IsActive = false},
                new Country { StrKey = "QA", CountryName = "QATAR", IsActive = false},
                new Country { StrKey = "RE", CountryName = "RÉUNION", IsActive = false},
                new Country { StrKey = "RO", CountryName = "ROMANIA", IsActive = false},
                new Country { StrKey = "RS", CountryName = "SERBIA", IsActive = false},
                new Country { StrKey = "RU", CountryName = "RUSSIAN FEDERATION", IsActive = false},
                new Country { StrKey = "RW", CountryName = "RWANDA", IsActive = false},
                new Country { StrKey = "SA", CountryName = "SAUDI ARABIA", IsActive = false},
                new Country { StrKey = "SB", CountryName = "SOLOMON ISLANDS", IsActive = false},
                new Country { StrKey = "SC", CountryName = "SEYCHELLES", IsActive = false},
                new Country { StrKey = "SD", CountryName = "SUDAN", IsActive = false},
                new Country { StrKey = "SE", CountryName = "SWEDEN", IsActive = false},
                new Country { StrKey = "SG", CountryName = "SINGAPORE", IsActive = false},
                new Country { StrKey = "SH", CountryName = "SAINT HELENA, ASCENSION AND TRISTAN DA CUNHA", IsActive = false},
                new Country { StrKey = "SI", CountryName = "SLOVENIA", IsActive = false},
                new Country { StrKey = "SJ", CountryName = "SVALBARD AND JAN MAYEN", IsActive = false},
                new Country { StrKey = "SK", CountryName = "SLOVAKIA", IsActive = false},
                new Country { StrKey = "SL", CountryName = "SIERRA LEONE", IsActive = false},
                new Country { StrKey = "SM", CountryName = "SAN MARINO", IsActive = false},
                new Country { StrKey = "SN", CountryName = "SENEGAL", IsActive = false},
                new Country { StrKey = "SO", CountryName = "SOMALIA", IsActive = false},
                new Country { StrKey = "SR", CountryName = "SURINAME", IsActive = false},
                new Country { StrKey = "SS", CountryName = "SOUTH SUDAN", IsActive = false},
                new Country { StrKey = "ST", CountryName = "SAO TOME AND PRINCIPE", IsActive = false},
                new Country { StrKey = "SV", CountryName = "EL SALVADOR", IsActive = false},
                new Country { StrKey = "SX", CountryName = "SINT MAARTEN (DUTCH PART)", IsActive = false},
                new Country { StrKey = "SY", CountryName = "SYRIAN ARAB REPUBLIC", IsActive = false},
                new Country { StrKey = "SZ", CountryName = "ESWATINI", IsActive = false},
                new Country { StrKey = "TC", CountryName = "TURKS AND CAICOS ISLANDS", IsActive = false},
                new Country { StrKey = "TD", CountryName = "CHAD", IsActive = false},
                new Country { StrKey = "TF", CountryName = "FRENCH SOUTHERN TERRITORIES", IsActive = false},
                new Country { StrKey = "TG", CountryName = "TOGO", IsActive = false},
                new Country { StrKey = "TH", CountryName = "THAILAND", IsActive = false},
                new Country { StrKey = "TJ", CountryName = "TAJIKISTAN", IsActive = false},
                new Country { StrKey = "TK", CountryName = "TOKELAU", IsActive = false},
                new Country { StrKey = "TL", CountryName = "TIMOR-LESTE", IsActive = false},
                new Country { StrKey = "TM", CountryName = "TURKMENISTAN", IsActive = false},
                new Country { StrKey = "TN", CountryName = "TUNISIA", IsActive = false},
                new Country { StrKey = "TO", CountryName = "TONGA", IsActive = false},
                new Country { StrKey = "TR", CountryName = "TURKEY", IsActive = false},
                new Country { StrKey = "TT", CountryName = "TRINIDAD AND TOBAGO", IsActive = false},
                new Country { StrKey = "TV", CountryName = "TUVALU", IsActive = false},
                new Country { StrKey = "TW", CountryName = "TAIWAN, PROVINCE OF CHINA", IsActive = false},
                new Country { StrKey = "TZ", CountryName = "TANZANIA, UNITED REPUBLIC OF", IsActive = false},
                new Country { StrKey = "UA", CountryName = "UKRAINE", IsActive = false},
                new Country { StrKey = "UG", CountryName = "UGANDA", IsActive = false},
                new Country { StrKey = "UM", CountryName = "UNITED STATES MINOR OUTLYING ISLANDS", IsActive = false},
                new Country { StrKey = "US", CountryName = "UNITED STATES OF AMERICA", IsActive = true},
                new Country { StrKey = "UY", CountryName = "URUGUAY", IsActive = false},
                new Country { StrKey = "UZ", CountryName = "UZBEKISTAN", IsActive = false},
                new Country { StrKey = "VA", CountryName = "HOLY SEE", IsActive = false},
                new Country { StrKey = "VC", CountryName = "SAINT VINCENT AND THE GRENADINES", IsActive = false},
                new Country { StrKey = "VE", CountryName = "VENEZUELA (BOLIVARIAN REPUBLIC OF)", IsActive = false},
                new Country { StrKey = "VG", CountryName = "VIRGIN ISLANDS (BRITISH)", IsActive = false},
                new Country { StrKey = "VI", CountryName = "VIRGIN ISLANDS (U.S.)", IsActive = false},
                new Country { StrKey = "VN", CountryName = "VIET NAM", IsActive = false},
                new Country { StrKey = "VU", CountryName = "VANUATU", IsActive = false},
                new Country { StrKey = "WF", CountryName = "WALLIS AND FUTUNA", IsActive = false},
                new Country { StrKey = "WS", CountryName = "SAMOA", IsActive = false},
                new Country { StrKey = "YE", CountryName = "YEMEN", IsActive = false},
                new Country { StrKey = "YT", CountryName = "MAYOTTE", IsActive = false},
                new Country { StrKey = "ZA", CountryName = "SOUTH AFRICA", IsActive = false},
                new Country { StrKey = "ZM", CountryName = "ZAMBIA", IsActive = false},
                new Country { StrKey = "ZW", CountryName = "ZIMBABWE", IsActive = false}
            };
            foreach (var item in countries.OrderBy(o => o.StrKey))
            {
                item.CountryId = countries.Max(m => m.CountryId) + 1;
            }
            return countries.ToArray();
        }
        public List<TaxOrganization> AddTaxOrganizations()
        {
            var countries = AddCountries().ToList<Country>();
            var countryMx = countries.Where(w => w.StrKey == "MX").FirstOrDefault();
            var countryUs = countries.Where(w => w.StrKey == "US").FirstOrDefault();
            List<TaxOrganization> taxOrg = new List<TaxOrganization> {
            new TaxOrganization { TaxOrganizationId = 1, CountryId = countryMx.CountryId, StrKey = "SAT", OrgDescription = "Servicio de Administración Tributaria"  },
            new TaxOrganization { TaxOrganizationId = 2, CountryId = countryUs.CountryId, StrKey = "IRS", OrgDescription = "Internal Revenue Service" }
            };
            return taxOrg;
        }
        public List<TaxOrganizationType> AddTaxOrganizationTypes()
        {
            List<TaxOrganizationType> taxOrgType = new List<TaxOrganizationType> {
            new TaxOrganizationType {TaxOrganizationTypeId = 1, TaxOrganizationId = 1, StrKey = "F", TypeDescription = "Persona Fisica"  },
            new TaxOrganizationType {TaxOrganizationTypeId = 2, TaxOrganizationId = 1, StrKey = "M", TypeDescription = "Persona Moral" },
            new TaxOrganizationType {TaxOrganizationTypeId = 3, TaxOrganizationId = 1, StrKey = "RG", TypeDescription = "RFC Genérico"  },
            new TaxOrganizationType {TaxOrganizationTypeId = 4, TaxOrganizationId = 1, StrKey = "RGE", TypeDescription = "RFC Genérico Extrangero"  }
            };
            return taxOrgType;
        }
        #endregion
    }
}
