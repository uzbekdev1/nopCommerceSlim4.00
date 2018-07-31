﻿using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a CAPTCHA settings model
    /// </summary>
    public partial class CaptchaSettingsModel : BaseNopModel, ISettingsModel
    {
        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.CaptchaEnabled")]
        public bool Enabled { get; set; }
        public bool Enabled_OverrideForStore { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.CaptchaShowOnLoginPage")]
        public bool ShowOnLoginPage { get; set; }
        public bool ShowOnLoginPage_OverrideForStore { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.CaptchaShowOnRegistrationPage")]
        public bool ShowOnRegistrationPage { get; set; }
        public bool ShowOnRegistrationPage_OverrideForStore { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.CaptchaShowOnContactUsPage")]
        public bool ShowOnContactUsPage { get; set; }
        public bool ShowOnContactUsPage_OverrideForStore { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.CaptchaShowOnEmailProductToFriendPage")]
        public bool ShowOnEmailProductToFriendPage { get; set; }
        public bool ShowOnEmailProductToFriendPage_OverrideForStore { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.CaptchaShowOnBlogCommentPage")]
        public bool ShowOnBlogCommentPage { get; set; }
        public bool ShowOnBlogCommentPage_OverrideForStore { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.CaptchaShowOnNewsCommentPage")]
        public bool ShowOnNewsCommentPage { get; set; }
        public bool ShowOnNewsCommentPage_OverrideForStore { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.CaptchaShowOnProductReviewPage")]
        public bool ShowOnProductReviewPage { get; set; }
        public bool ShowOnProductReviewPage_OverrideForStore { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.CaptchaShowOnApplyVendorPage")]
        public bool ShowOnApplyVendorPage { get; set; }
        public bool ShowOnApplyVendorPage_OverrideForStore { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.reCaptchaPublicKey")]
        public string ReCaptchaPublicKey { get; set; }
        public bool ReCaptchaPublicKey_OverrideForStore { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.reCaptchaPrivateKey")]
        public string ReCaptchaPrivateKey { get; set; }
        public bool ReCaptchaPrivateKey_OverrideForStore { get; set; }        

        #endregion
    }
}