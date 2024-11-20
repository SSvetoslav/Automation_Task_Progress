using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Progress.Utils;
using SeleniumExtras.WaitHelpers;

namespace Progress.Pages
{
    internal abstract class WebPage
    {
        private IWebDriver Driver { get; init; }
        private WebDriverWait Wait { get; set; }
        private Actions Actions { get;  set; }
        protected Localization Localization { get; init; }

        private const int TIMEOUT = 10;

        protected string RGBColorValue = "rgb(185, 1, 56)"; // Read boarder Message field

        protected static string URLContactPageEngland = "https://www.progress.com/company/contact";
        protected static string URLContactPageDeutsch = "https://www.progress.com/de/unternehmen/kontakt";
        protected static string URLContactPageNederlands = "https://www.progress.com/nl/bedrijf/contact";
        protected static string URLContactPageFrance = "https://www.progress.com/fr/entreprise/contact-commercial";
        protected static string URLContactPageSpain = "https://www.progress.com/es/empresa/contacto";
        protected static string URLContactPagePortugal = "https://www.progress.com/pt/empresa/contato";
        protected static string URLContactPageCzechRepublic = "https://www.progress.com/cs/spolecnost/kontakt";
        protected static string URLContactPageJapan = "https://www.progress.com/jp/company/contact";
        protected static string URLContactPageTaiwan = "https://www.progress.com/tw/company/contact";

        // Labels - Contact form
        /// <summary>
        ///  This varaibles will be set for each instance of class WebPage in constructor, based at Localization param
        /// </summary>
        /// 
        protected static string LabelGetInTouch { get; private set; }
        protected static string LabelHowCanWeHelp { get; private set; }
        protected static string LabelProduct { get; private set; }
        protected static string LabelBusinessEmail { get; private set; }
        protected static string LabelFirstName { get; private set; }
        protected static string LabelLastName { get; private set; }
        protected static string LabelCompany { get; private set; }
        protected static string LabelIam { get; private set; }
        protected static string LabelCountry { get; private set; }
        protected static string LabelPhone { get; private set; }
        protected static string LabelMessage { get; private set; }
        protected static string LabelIfYouHaveQuestions { get; private set; }
        protected static string LabelDonotSellOrShareMyPersonalInformation { get; private set; }

        // Submit button - Contact form
        /// <summary>
        ///  This varaibles will be set for each instance of class WebPage in constructor, based at Localization param
        /// </summary>
        protected static string ButtonContactSales { get; private set; }

        // Error messages - Contact form
        /// <summary>
        ///  This varaibles will be set for each instance of class WebPage in constructor, based at Localization param
        /// </summary>
        protected static string ErrorMessageProduct { get; private set; }
        protected static string ErrorMessageBusinessEmail { get; private set; }
        protected static string ErrorMessageFirstName { get; private set; }
        protected static string ErrorMessageLastName { get; private set; }
        protected static string ErrorMessageCompany { get; private set; }
        protected static string ErrorMessageCountry { get; private set; }
        protected static string ErrorMessagePhone { get; private set; }

        protected static string ErrorMessageFirstNameInvalidFormat { get; private set; } 
        protected static string ErrorMessageLastNameInvalidFormat { get; private set; } 


        // Footer - elements
        /// <summary>
        ///  This varaibles will be set for each instance of class WebPage in constructor, based at Localization param
        ///  Technoligy, Quick Links, About
        /// </summary>
        // Technology
        protected static string LinkDataPlatform { get; private set; }
        protected static string LinkDataConnectivity { get; private set; }
        protected static string LinkDigitalExperience { get; private set; }
        protected static string LinkDevOps { get; private set; }
        protected static string LinkInfrastructureManagementAndOperations { get; private set; }
        protected static string LinkUIUXTools { get; private set; }
        protected static string LinkSecureFileTransfer { get; private set; }
        protected static string LinkMissionCriticalAppPlatform { get; private set; }

        // Quick Links
        protected static string LinkProducts { get; private set; }
        protected static string LinkTrials { get; private set; }
        protected static string LinkServices { get; private set; }
        protected static string LinkPartners { get; private set; }
        protected static string LinkSupport { get; private set; }
        protected static string LinkEvents { get; private set; }
        protected static string LinkBlogs { get; private set; }

        // About
        protected static string LinkCompany { get; private set; }
        protected static string LinkCustomerStories { get; private set; }
        protected static string LinkAwards { get; private set; }
        protected static string LinkInvestorRelations { get; private set; }
        protected static string LinkOffices { get; private set; }
        protected static string LinkCareers { get; private set; }
        protected static string Link40YearsOfProgress { get; private set; }

        // Contact
        protected static string LinkContancUs { get; private set; }
        protected static string LinkPhoneNumber { get; private set; }

        // Cookie
        protected static string ButtonCookie { get; private set; }
        protected static string TabYourPrivacy { get; private set; }
        protected static string TabStrictlyNecessaryCookies { get; private set; }
        protected static string TabPerformanceCookies { get; private set; }
        protected static string TabFunctionalCookies { get; private set; }
        protected static string TabTargetingCookies { get; private set; }
        protected static string ButtonSaveSettings { get; private set; }
        protected static string ButtonAllowAll { get; private set; }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="driver"> Current instance of IWebDriver </param>
        /// <param name="localization"> Localization - set different localizations. Default localization - England </param>
        public WebPage(IWebDriver driver, Localization localization = Localization.England)
        {
            this.Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Localization = localization;
            LogInitialization();
            this.Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TIMEOUT));
            this.Actions = new Actions(Driver);
            SetLocalization(localization);
        }

        private void LogInitialization()
        {
            Console.WriteLine($"Localization is set to: {Localization}");
            Console.WriteLine($"Tests will be executed for {Localization}");
        }

        private void SetLocalization(Localization localization)
        {
            LinkContancUs = "Contact us";
            LinkPhoneNumber = "1-800-477-6473";

            switch (localization) 
            {
                case Localization.England:
                    // Contact form
                    LabelGetInTouch = "Get in Touch";
                    LabelProduct = "Product / interest";
                    LabelBusinessEmail = "Business Email";
                    LabelFirstName = "First Name";
                    LabelLastName = "Last Name";
                    LabelCompany = "Company";
                    LabelIam = "I am...";
                    LabelCountry = "Country/Territory";
                    LabelMessage = "Message";
                    LabelPhone = "Phone";
                    ButtonContactSales = "Contact sales";
                    LabelHowCanWeHelp = "How Can We Help?";
                    LabelIfYouHaveQuestions = "If you’re considering Progress or just have a question, simply fill out the form and we’ll be in touch with you.";
                    LabelDonotSellOrShareMyPersonalInformation = "DO NOT SELL OR SHARE MY PERSONAL INFORMATION";

                    // Errors
                    ErrorMessageProduct = "Product is required";
                    ErrorMessageBusinessEmail = "Email is required";
                    ErrorMessageFirstName = "First name is required";
                    ErrorMessageLastName = "Last name is required";
                    ErrorMessageCompany = "Company is required";
                    ErrorMessageCountry = "Country/territory is required";
                    ErrorMessagePhone = "Phone is required";

                    ErrorMessageFirstNameInvalidFormat = "Invalid format";
                    ErrorMessageLastNameInvalidFormat = "Invalid format";

                    // Footer
                    // Technology
                    LinkDataPlatform = "Data Platform";
                    LinkDataConnectivity = "Data Connectivity";
                    LinkDigitalExperience = "Digital Experience";
                    LinkDevOps = "DevOps";
                    LinkInfrastructureManagementAndOperations = "Infrastructure Management & Operations";
                    LinkUIUXTools = "UI/UX Tools";
                    LinkSecureFileTransfer = "Secure File Transfer";

                    // Quick Links
                    LinkProducts = "Products";
                    LinkTrials = "Trials";
                    LinkServices = "Services";
                    LinkPartners = "Partners";
                    LinkSupport = "Support";
                    LinkEvents = "Events";
                    LinkBlogs = "Blogs";

                    // About
                    LinkCompany = "Company";
                    LinkCustomerStories = "Customer Stories";
                    LinkAwards = "Awards";
                    LinkInvestorRelations = "Investor relations";
                    LinkOffices = "Offices";
                    LinkCareers = "Careers";
                    Link40YearsOfProgress = "40 Years of Progress";

                    // Cookies
                    ButtonCookie = "Open Preferences";
                    ButtonSaveSettings = "Save Settings";
                    TabPerformanceCookies = "Performance Cookies"; // //h3[contains(.,'Performance Cookies')]
                    TabFunctionalCookies = "Functional Cookies"; // //h4[@class='ot-cat-header'][contains(.,'Functional Cookies')]
                    TabTargetingCookies = "Targeting Cookies"; // //h3[contains(.,'Targeting Cookies')]
                    ButtonAllowAll = "Allow All"; // //button[contains(.,'Allow All')]
                    break;

                case Localization.Deutsch:
                    // Contact form
                    LabelGetInTouch = "Kontakt aufnehmen";
                    LabelProduct = "Produkt / Interesse";
                    LabelBusinessEmail = "Geschäftliche E-Mail";
                    LabelFirstName = "Vorname";
                    LabelLastName = "Nachname";
                    LabelCompany = "Unternehmen";
                    LabelIam = "Ich bin ...";
                    LabelCountry = "Land/Region";
                    LabelPhone = "Telefon";
                    LabelMessage = "Nachricht";
                    ButtonContactSales = "Kontakt Vertrieb";
                    LabelHowCanWeHelp = "Wie können wir helfen?";
                    LabelIfYouHaveQuestions = "Wenn Sie Progress in Erwägung ziehen oder einfach nur eine Frage haben, füllen Sie einfach das Formular aus und wir werden uns mit Ihnen in Verbindung setzen.";
                    LabelDonotSellOrShareMyPersonalInformation = "ICH MÖCHTE NICHT, DASS MEINE PERSÖNLICHEN DATEN VERKAUFT ODER WEITERGEGEBEN WERDEN";

                    // Errors
                    ErrorMessageProduct = "Produkt ist erforderlich";
                    ErrorMessageBusinessEmail = "E-Mail ist erforderlich.";
                    ErrorMessageFirstName = "Vorname ist erforderlich";
                    ErrorMessageLastName = "Nachname ist erforderlich";
                    ErrorMessageCompany = "Unternehmen";
                    ErrorMessageCountry = "Land/Region ist erforderlich";
                    ErrorMessagePhone = "Telefon ist erforderlich";

                    ErrorMessageFirstNameInvalidFormat = "Invalid format";
                    ErrorMessageLastNameInvalidFormat = "Invalid format";

                    // Footer
                    // Technology
                    LinkDataPlatform = "Digital Decisioning";
                    LinkDataConnectivity = "Secure Data Connectivity and Integration";
                    LinkDigitalExperience = "Digital Experience";
                    LinkDevOps = "DevOps";
                    LinkInfrastructureManagementAndOperations = "Infrastructure Monitoring";
                    LinkUIUXTools = "UI/UX Tools";
                    LinkSecureFileTransfer = "Secure Managed File Transfer";
                    LinkMissionCriticalAppPlatform = "Mission-Critical App Platform";

                    // Quick Links
                    LinkProducts = "Products";
                    LinkTrials = "Trials";
                    LinkServices = "Services";
                    LinkPartners = "Partners";
                    LinkSupport = "Support";
                    LinkBlogs = "Blogs";

                    // About
                    LinkCompany = "Company";
                    LinkCustomerStories = "Customers";
                    LinkInvestorRelations = "Investor relations";
                    LinkOffices = "Offices";
                    LinkCareers = "Careers";
                    Link40YearsOfProgress = "40 Jahre feiern";

                    // Cookies
                    ButtonCookie = "Präferenzen öffnen";
                    ButtonSaveSettings = "Einstellungen speichern";
                    TabPerformanceCookies = "Leistungs-Cookies";
                    TabFunctionalCookies = "Funktionelle Cookies";
                    TabTargetingCookies = "Cookies für Marketingzwecke";
                    ButtonAllowAll = "Alle zulassen";
                    break;

                case Localization.Nederlands:
                    // Contact form
                    LabelGetInTouch = "Vul formulier in";
                    LabelProduct = "Product / interesse";
                    LabelBusinessEmail = "Bedrijfsemailadres";
                    LabelFirstName = "Voornaam";
                    LabelLastName = "Achternaam";
                    LabelCompany = "Bedrijf";
                    LabelIam = "Ik ben…";
                    LabelCountry = "land";
                    LabelPhone = "Telefoon";
                    LabelMessage = "Boodschap";
                    ButtonContactSales = "Contacteer Verkoop";
                    LabelHowCanWeHelp = "Hoe kunnen we jou helpen?";
                    LabelIfYouHaveQuestions = "Heb je een vraag? Vul dan het formulier in en we nemen contact met je op.";
                    LabelDonotSellOrShareMyPersonalInformation = "DO NOT SELL OR SHARE MY PERSONAL INFORMATION";

                    // Errors
                    ErrorMessageProduct = "Kies een product";
                    ErrorMessageBusinessEmail = "Email ontbreekt";
                    ErrorMessageFirstName = "Voornaam ontbreekt";
                    ErrorMessageLastName = "Achternaam ontbreekt";
                    ErrorMessageCompany = "Bedrijfsnaam ontbreekt";
                    ErrorMessageCountry = "Kies een land";
                    ErrorMessagePhone = "Telefoonnummer ontbreekt";

                    ErrorMessageFirstNameInvalidFormat = "Invalid format";
                    ErrorMessageLastNameInvalidFormat = "Invalid format";

                    // Footer
                    // Technology
                    LinkDataPlatform = "Digital Decisioning";
                    LinkDataConnectivity = "Secure Data Connectivity and Integration";
                    LinkDigitalExperience = "Digital Experience";
                    LinkDevOps = "DevOps";
                    LinkInfrastructureManagementAndOperations = "Infrastructure Monitoring";
                    LinkUIUXTools = "UI/UX Tools";
                    LinkSecureFileTransfer = "Secure Managed File Transfer";
                    LinkMissionCriticalAppPlatform = "Mission-Critical App Platform";

                    // Quick Links
                    LinkProducts = "Products";
                    LinkTrials = "Trials";
                    LinkServices = "Services";
                    LinkPartners = "Partners";
                    LinkSupport = "Support";
                    LinkBlogs = "Blogs";

                    // About
                    LinkCompany = "Company";
                    LinkCustomerStories = "Customers";
                    LinkInvestorRelations = "Investor relations";
                    LinkOffices = "Offices";
                    LinkCareers = "Careers";
                    Link40YearsOfProgress = "40 Years of Progress";

                    // Cookies
                    ButtonCookie = "Voorkeuren openen";
                    ButtonSaveSettings = "Mijn keuzes bevestigen";
                    TabPerformanceCookies = "Prestatiecookies";
                    TabFunctionalCookies = "Functionele cookies";
                    TabTargetingCookies = "Doelgroepgerichte cookies";
                    ButtonAllowAll = "Alle toestaan";
                    break;

                case Localization.France:
                    // Contact form
                    LabelGetInTouch = "Contactez-nous";
                    LabelProduct = "Produit / intérêt";
                    LabelBusinessEmail = "E-mail professionnel";
                    LabelFirstName = "Prénom";
                    LabelLastName = "Nom";
                    LabelCompany = "Entreprise";
                    LabelIam = "Je suis ...";
                    LabelCountry = "Pays";
                    LabelPhone = "Téléphone";
                    LabelMessage = "Message";
                    ButtonContactSales = "Contactez-nous";
                    LabelHowCanWeHelp = "Comment pouvons-nous vous aider?";
                    LabelIfYouHaveQuestions = "Si vous envisagez de faire appel à Progress ou si vous avez simplement une question, il vous suffit de remplir le formulaire et nous vous contacterons.";
                    LabelDonotSellOrShareMyPersonalInformation = "MERCI DE NE PAS VENDRE OU PARTAGER MES DONNÉES PERSONNELLES";

                    // Errors
                    ErrorMessageProduct = "Le produit est requis";
                    ErrorMessageBusinessEmail = "L'e-mail est obligatoire";
                    ErrorMessageFirstName = "Le prénom est requis";
                    ErrorMessageLastName = "Le nom est requis";
                    ErrorMessageCompany = "L'entreprise est requise";
                    ErrorMessageCountry = "Le pays est requis";
                    ErrorMessagePhone = "Le numéro de téléphone est requis";

                    ErrorMessageFirstNameInvalidFormat = "Invalid format";
                    ErrorMessageLastNameInvalidFormat = "Invalid format";

                    // Footer
                    // Technology
                    LinkDataPlatform = "Prise de décision intelligente";
                    LinkDataConnectivity = "Connectivité et intégration sécurisées des données";
                    LinkDigitalExperience = "Expérience numérique";
                    LinkDevOps = "DevOps";
                    LinkInfrastructureManagementAndOperations = "Surveillance des infrastructures";
                    LinkUIUXTools = "Outils UI/UX";
                    LinkSecureFileTransfer = "Transfert de fichiers sécurisé";
                    LinkMissionCriticalAppPlatform = "Plateforme d'applications stratégiques";

                    // Quick Links
                    LinkProducts = "Logiciels";
                    LinkTrials = "Essais";
                    LinkServices = "Services";
                    LinkPartners = "Partenaires";
                    LinkSupport = "Support";
                    LinkBlogs = "Blogs";

                    // About
                    LinkCompany = "Entreprise";
                    LinkCustomerStories = "Clients";
                    LinkInvestorRelations = "Relations investisseurs";
                    LinkOffices = "Bureaux";
                    LinkCareers = "Carrières";
                    Link40YearsOfProgress = "Célébrons 40 ans";

                    // Cookies
                    ButtonCookie = "Ouvrir le centre de préférences";
                    ButtonSaveSettings = "Enregistrer les paramètres";
                    TabPerformanceCookies = "Cookies de performance";
                    TabFunctionalCookies = "Cookies de fonctionnalité";
                    TabTargetingCookies = "Cookies pour une publicité ciblée";
                    ButtonAllowAll = "Tout autoriser";
                    break;

                case Localization.Spain:
                    // Contact form
                    LabelGetInTouch = "Entra en contacto";
                    LabelProduct = "Productos / intereses";
                    LabelBusinessEmail = "Correo electrónico empresarial";
                    LabelFirstName = "Nombre";
                    LabelLastName = "Apellido";
                    LabelCompany = "Empresa";
                    LabelIam = "Soy...";
                    LabelCountry = "País/Territorio";
                    LabelPhone = "Teléfono";
                    LabelMessage = "Mensaje";
                    ButtonContactSales = "Entre en contacto con Ventas";
                    LabelHowCanWeHelp = "¿Cómo podemos ayudar?";
                    LabelIfYouHaveQuestions = "Si está considerando Progress o simplemente tiene una pregunta, entre en contacto con nosotros y con gusto nos pondremos en contacto con usted.";
                    LabelDonotSellOrShareMyPersonalInformation = "NO VENDER O COMPARTIR MIS DATOS PERSONALES";

                    // Errors
                    ErrorMessageProduct = "Producto requerido";
                    ErrorMessageBusinessEmail = "Se requiere el email";
                    ErrorMessageFirstName = "El nombre es requerido";
                    ErrorMessageLastName = "Se requiere el apellido";
                    ErrorMessageCompany = "Se requiere la empresa";
                    ErrorMessageCountry = "Se requiere el país/territorio";
                    ErrorMessagePhone = "Se requiere el teléfono";

                    ErrorMessageFirstNameInvalidFormat = "Invalid format";
                    ErrorMessageLastNameInvalidFormat = "Invalid format";

                    // Footer
                    // Technology
                    LinkDataPlatform = "Digital Decisioning";
                    LinkDataConnectivity = "Secure Data Connectivity and Integration";
                    LinkDigitalExperience = "Digital Experience";
                    LinkDevOps = "DevOps";
                    LinkInfrastructureManagementAndOperations = "Infrastructure Monitoring";
                    LinkUIUXTools = "UI/UX Tools";
                    LinkSecureFileTransfer = "Secure Managed File Transfer";
                    LinkMissionCriticalAppPlatform = "Mission-Critical App Platform";

                    // Quick Links
                    LinkProducts = "Products";
                    LinkTrials = "Trials";
                    LinkServices = "Services";
                    LinkPartners = "Partners";
                    LinkSupport = "Support";
                    LinkBlogs = "Blogs";

                    // About
                    LinkCompany = "Company";
                    LinkCustomerStories = "Customers";
                    LinkInvestorRelations = "Investor relations";
                    LinkOffices = "Oficinas";
                    LinkCareers = "Careers";
                    Link40YearsOfProgress = "Celebrando 40 Años";

                    // Cookies
                    ButtonCookie = "Abrir preferencias";
                    ButtonSaveSettings = "Guardar configuración";
                    TabPerformanceCookies = "Cookies de rendimiento";
                    TabFunctionalCookies = "Cookies de funcionalidad";
                    TabTargetingCookies = "Cookies dirigidas";
                    ButtonAllowAll = "Permitirlas todas";
                    break;

                case Localization.Portugal:
                    // Contact form
                    LabelGetInTouch = "Contate-nos";
                    LabelProduct = "Produtos / interesses";
                    LabelBusinessEmail = "E-mail comercial";
                    LabelFirstName = "Primeiro nome";
                    LabelLastName = "Apelido";
                    LabelCompany = "Empresa";
                    LabelIam = "Eu sou...";
                    LabelCountry = "País/Território";
                    LabelPhone = "Telefone";
                    LabelMessage = "Mensagem";
                    ButtonContactSales = "Contato de Vendas";
                    LabelHowCanWeHelp = "Como podemos ajudar?";
                    LabelIfYouHaveQuestions = "Se você está considerando Progress ou simplesmente";
                    LabelDonotSellOrShareMyPersonalInformation = "NÃO VENDER OU COMPARTILHAR MEUS DADOS PESSOAIS";

                    // Errors
                    ErrorMessageProduct = "Produto necessário";
                    ErrorMessageBusinessEmail = "E-mail necessário";
                    ErrorMessageFirstName = "O primeiro nome é obrigatório";
                    ErrorMessageLastName = "O sobrenome é obrigatório";
                    ErrorMessageCompany = "A empresa é obrigada";
                    ErrorMessageCountry = "País/território é necessário";
                    ErrorMessagePhone = "O número de telefone é necessário";

                    ErrorMessageFirstNameInvalidFormat = "Invalid format";
                    ErrorMessageLastNameInvalidFormat = "Invalid format";

                    // Footer
                    // Technology
                    LinkDataPlatform = "Digital Decisioning";
                    LinkDataConnectivity = "Secure Data Connectivity and Integration";
                    LinkDigitalExperience = "Digital Experience";
                    LinkDevOps = "DevOps";
                    LinkInfrastructureManagementAndOperations = "Infrastructure Monitoring";
                    LinkUIUXTools = "UI/UX Tools";
                    LinkSecureFileTransfer = "Secure Managed File Transfer";
                    LinkMissionCriticalAppPlatform = "Mission-Critical App Platform";

                    // Quick Links
                    LinkProducts = "Products";
                    LinkTrials = "Trials";
                    LinkServices = "Services";
                    LinkPartners = "Partners";
                    LinkSupport = "Support";
                    LinkBlogs = "Blogs";

                    // About
                    LinkCompany = "Company";
                    LinkCustomerStories = "Customers";
                    LinkInvestorRelations = "Investor relations";
                    LinkOffices = "Offices";
                    LinkCareers = "Careers";
                    Link40YearsOfProgress = "40 Years of Progress";

                    // Cookies
                    ButtonCookie = "Abrir preferências";
                    ButtonSaveSettings = "Guardar definições";
                    TabPerformanceCookies = "Cookies de desempenho";
                    TabFunctionalCookies = "Cookies de funcionalidade";
                    TabTargetingCookies = "Cookies de publicidade";
                    ButtonAllowAll = "Permitir todos";
                    break;

                case Localization.CzechRepublic:
                    // Contact form
                    LabelGetInTouch = "Napište nám";
                    LabelProduct = "Produkt/obor";
                    LabelBusinessEmail = "Firemní e-mail";
                    LabelFirstName = "Křestní jméno";
                    LabelLastName = "Příjmení";
                    LabelCompany = "Společnost";
                    LabelIam = "Typ společnosti";
                    LabelCountry = "Země";
                    LabelPhone = "Telefon";
                    LabelMessage = "Vaše zpráva";
                    ButtonContactSales = "Zaregistrovat se";
                    LabelHowCanWeHelp = "Potřebujete pomoc?";
                    LabelIfYouHaveQuestions = "Chcete využít služby společnosti Progress? Nebo máte nějaký dotaz? Vyplňte kontaktní formulář a my se vám ozveme.";
                    LabelDonotSellOrShareMyPersonalInformation = "NEPRODÁVAJTE MÉ OSOBNÍ ÚDAJE";

                    // Errors
                    ErrorMessageProduct = "Prosím, zadejte produkt";
                    ErrorMessageBusinessEmail = "Prosím, zadejte e-mail";
                    ErrorMessageFirstName = "Prosím, zadejte své křestní jméno";
                    ErrorMessageLastName = "Příjmení\n\nProsím, zadejte své příjmení";
                    ErrorMessageCompany = "Prosím, zadejte název společnosti";
                    ErrorMessageCountry = "Prosím, zadejte svůj stát / svou oblast";
                    ErrorMessagePhone = "Prosím, zadejte telefon";

                    ErrorMessageFirstNameInvalidFormat = "Invalid format";
                    ErrorMessageLastNameInvalidFormat = "Invalid format";

                    // Footer
                    // Technology
                    LinkDataPlatform = "Digital Decisioning";
                    LinkDataConnectivity = "Secure Data Connectivity and Integration";
                    LinkDigitalExperience = "Digital Experience";
                    LinkDevOps = "DevOps";
                    LinkInfrastructureManagementAndOperations = "Infrastructure Monitoring";
                    LinkUIUXTools = "UI/UX Tools";
                    LinkSecureFileTransfer = "Secure Managed File Transfer";
                    LinkMissionCriticalAppPlatform = "Mission-Critical App Platform";

                    // Quick Links
                    LinkProducts = "Products";
                    LinkTrials = "Trials";
                    LinkServices = "Services";
                    LinkPartners = "Partners";
                    LinkSupport = "Support";
                    LinkBlogs = "Blogs";

                    // About
                    LinkCompany = "Company";
                    LinkCustomerStories = "Customers";
                    LinkInvestorRelations = "Investor relations";
                    LinkOffices = "Offices";
                    LinkCareers = "Careers";
                    Link40YearsOfProgress = "40 Years of Progress";

                    // Cookies
                    ButtonCookie = "Otevřít předvolby";
                    ButtonSaveSettings = "Uložit nastavení";
                    TabPerformanceCookies = "Výkonnostní cookies";
                    TabFunctionalCookies = "Funkční cookies";
                    TabTargetingCookies = "Cookies pro cílení";
                    ButtonAllowAll = "Povolit vše";
                    break;

                case Localization.Japan:
                    // Contact form
                    LabelGetInTouch = "下のフォームにご記入ください";
                    LabelProduct = "製品または関心事項";
                    LabelBusinessEmail = "会社のメール・アドレス";
                    LabelFirstName = "名";
                    LabelLastName = "姓";
                    LabelCompany = "会社";
                    LabelIam = "業種";
                    LabelCountry = "国";
                    LabelPhone = "電話番号";
                    LabelMessage = "メッセージ";
                    ButtonContactSales = "送信";
                    LabelHowCanWeHelp = "お問い合わせ";
                    LabelIfYouHaveQuestions = "下のフォームに必要事項を記入して送信して";
                    LabelDonotSellOrShareMyPersonalInformation = "個人情報の販売または共有を不許可";

                    // Errors
                    ErrorMessageProduct = "製品を選択してください";
                    ErrorMessageBusinessEmail = "メール・アドレスを入力してください";
                    ErrorMessageFirstName = "お名前（ファーストネーム）をご記入ください";
                    ErrorMessageLastName = "姓をご記入ください";
                    ErrorMessageCompany = "会社名をご入力ください";
                    ErrorMessageCountry = "国をご選択ください";
                    ErrorMessagePhone = "有効な電話番号を入力してください";

                    ErrorMessageFirstNameInvalidFormat = "Invalid format";
                    ErrorMessageLastNameInvalidFormat = "Invalid format";

                    // Footer
                    // Technology
                    LinkDataPlatform = "Digital Decisioning";
                    LinkDataConnectivity = "Secure Data Connectivity and Integration";
                    LinkDigitalExperience = "Digital Experience";
                    LinkDevOps = "DevOps";
                    LinkInfrastructureManagementAndOperations = "Infrastructure Monitoring";
                    LinkUIUXTools = "UI/UX Tools";
                    LinkSecureFileTransfer = "Secure Managed File Transfer";
                    LinkMissionCriticalAppPlatform = "Mission-Critical App Platform";

                    // Quick Links
                    LinkProducts = "Products";
                    LinkTrials = "Trials";
                    LinkServices = "Services";
                    LinkPartners = "Partners";
                    LinkSupport = "Support";
                    LinkBlogs = "Blogs";

                    // About
                    LinkCompany = "Company";
                    LinkCustomerStories = "Customers";
                    LinkInvestorRelations = "Investor relations";
                    LinkOffices = "Offices";
                    LinkCareers = "Careers";

                    // Cookies
                    ButtonCookie = "優先設定センターを開く";
                    ButtonSaveSettings = "設定を保存する";
                    TabPerformanceCookies = "パフォーマンス Cookie";
                    TabFunctionalCookies = "機能性 Cookie";
                    TabTargetingCookies = "ターゲティング Cookie";
                    ButtonAllowAll = "すべて許可する";
                    break;

                case Localization.Taiwan:
                    // Contact form
                    LabelGetInTouch = "填寫下面的表格";
                    LabelProduct = "感興趣的產品或項目";
                    LabelBusinessEmail = "公司電子郵件";
                    LabelFirstName = "名字";
                    LabelLastName = "姓氏";
                    LabelCompany = "公司";
                    LabelIam = "行業";
                    LabelCountry = "國家/地區";
                    LabelPhone = "電話號碼";
                    LabelMessage = "信息";
                    ButtonContactSales = "送出";
                    LabelHowCanWeHelp = "聯絡我們";
                    LabelIfYouHaveQuestions = "請填寫下面的表格。我們會盡快回覆您。";
                    LabelDonotSellOrShareMyPersonalInformation = "DO NOT SELL OR SHARE MY PERSONAL INFORMATION";

                    // Errors
                    ErrorMessageProduct = "產品是必填欄位";
                    ErrorMessageBusinessEmail = "電子郵件是必填欄位";
                    ErrorMessageFirstName = "名字是必填欄位";
                    ErrorMessageLastName = "姓氏是必填欄位";
                    ErrorMessageCompany = "公司是必填欄位";
                    ErrorMessageCountry = "國家/地區是必填欄位";
                    ErrorMessagePhone = "請輸入正確的電話號碼";

                    ErrorMessageFirstNameInvalidFormat = "Invalid format";
                    ErrorMessageLastNameInvalidFormat = "Invalid format";

                    // Footer
                    // Technology
                    LinkDataPlatform = "Digital Decisioning";
                    LinkDataConnectivity = "Secure Data Connectivity and Integration";
                    LinkDigitalExperience = "Digital Experience";
                    LinkDevOps = "DevOps";
                    LinkInfrastructureManagementAndOperations = "Infrastructure Monitoring";
                    LinkUIUXTools = "UI/UX Tools";
                    LinkSecureFileTransfer = "Secure Managed File Transfer";
                    LinkMissionCriticalAppPlatform = "Mission-Critical App Platform";

                    // Quick Links
                    LinkProducts = "Products";
                    LinkTrials = "Trials";
                    LinkServices = "Services";
                    LinkPartners = "Partners";
                    LinkSupport = "Support";
                    LinkBlogs = "Blogs";

                    // About
                    LinkCompany = "Company";
                    LinkCustomerStories = "Customers";
                    LinkInvestorRelations = "Investor relations";
                    LinkOffices = "Offices";
                    LinkCareers = "Careers";
                    Link40YearsOfProgress = "40 Years of Progress";

                    // Cookies
                    ButtonCookie = "打开偏好";
                    ButtonSaveSettings = "保存設置";
                    TabPerformanceCookies = "性能 Cookie";
                    TabFunctionalCookies = "功能 Cookie";
                    TabTargetingCookies = "定向 Cookie";
                    ButtonAllowAll = "全部允许";
                    break;
            }
        }

        protected IWebElement FindElement(By by) => Wait.Until(ExpectedConditions.ElementIsVisible(by));
        protected IWebElement WaitsUntilVisible(By elementLocator) => Wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));
        protected IList<IWebElement> FindElements(By by) => Driver.FindElements(by);
        protected string GetText(By by) => FindElement(by).Text;
        protected string GetUrl() => Driver.Url;
        protected string GetAttribute(By by, string attribute) => FindElement(by).GetAttribute(attribute);
        protected string GetCSSValue(By by, string attribute) => FindElement(by).GetCssValue(attribute);

        protected void StartApp(string page)
        {
            OpenPage(page);
        }

        protected void Click(By by)
        {
            FindElement(by).Click();
        }

        protected void Type(By by, string text)
        {
            var element = FindElement(by);
            element.Clear();
            element.SendKeys(text);
        }

        protected void ScrollToElement(By by)
        {
            new Actions(Driver)
               .ScrollToElement(FindElement(by))
               .Perform();
        }

        protected void ClickJS(By by)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(by));
        }

        protected void WaitUntilNotVisible(By by)
        {
            Wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }

        protected void SwitchToNewWindow()
        {
            try
            {
                Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            }
            catch (NoSuchWindowException)
            {
                Assert.Pass("NoSuchWindowException was correctly handled.");
            }
            catch (Exception ex)
            {
                Assert.Fail("An unexpected exception was thrown: " + ex.Message);
            }
            finally
            {
                Driver.SwitchTo().Window(Driver.WindowHandles[0]);
                Console.WriteLine("Error, can not switch to new window!");
            }
        }

        protected void HooverElement(By by)
        {
            Actions.MoveToElement(FindElement(by))
                .MoveByOffset(1, 1)
                .Build()
                .Perform();
        }

        protected bool ElementPresent(By by, int timeout = TIMEOUT)
        {
            int i = 0;
            var present = false;

            while (present == false && i < timeout)
            {
                try
                {
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
                    IWebElement element = Driver.FindElement(by);
                    present = element.Displayed;
                    if (!present)
                    {
                        Console.WriteLine($"Element {by} not found/Displayed in iteration {i}. Repeating after 1 sec. Element enabled: {present}");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine($"Element {by} found/Displayed in iteration {i}. Continuing test. Element enabled: {present}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Element {by} not found/Displayed in iteration {i}. Repeating after 1 sec. Element enabled: {present}");
                    Thread.Sleep(1000);
                }
                finally
                {
                    i++;
                }
            }

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TIMEOUT);
            return present;
        }

        protected void SelectsDropDownItem(By by, string optionValue)
        {
            IWebElement element = FindElement(by);
            SelectElement dropDownElement = new(element);

            if (!dropDownElement.SelectedOption.GetDomProperty("value").Equals(optionValue))
            {
                dropDownElement.SelectByValue(optionValue);
            }
        }

        public void RefreshPage()
        {
            Driver.Navigate().Refresh();
        }

        protected void SwitchToDefaultWindow()
        {
            try
            {
                Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            }
            catch (Exception ex)
            {
                Assert.Fail("An unexpected exception was thrown: " + ex.Message);
            }
        }

        //protected virtual void WaitForPageToLoad() {}

        private void OpenPage(string pageName)
        {
            Driver.Navigate().GoToUrl(pageName);
        }
    }
}
