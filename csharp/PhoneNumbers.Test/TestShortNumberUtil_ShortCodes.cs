using NUnit.Framework;

namespace PhoneNumbers.Test.TestShortNumberUtil_ShortCodes
{
    public class GivenAShortNumberUtil
    {
        protected ShortNumberUtil _sut;
        protected PhoneNumberUtil _phoneNumberUtil;

        [SetUp]
        public void Given() {
            PhoneNumberUtil.ResetInstance();
            _phoneNumberUtil = PhoneNumberUtil.GetInstance();
            _sut = new ShortNumberUtil(_phoneNumberUtil);
        }
    }

    public class WhenIsShortcodeNumberIsCalled : GivenAShortNumberUtil
    {
        [Test]
        public void ItShouldReturnFalseForInvalidRegionCode() {
            Assert.That(_sut.IsShortcodeNumber("some number", "some invalid region code"), Is.False);
        }

        [Test]
        public void ItShouldReturnFalseForValidRegionCodeThatDoesNotHaveShortcodeMetadataDefined() {

            const string aValidRegionCodeThatDoesNotHaveShortcodeMetadataDefined = "AD";

            // Validate precondition; verify that AD really does not support short code (in case this changes in the future)
            var aValidRegionThatDoesNotHaveShortcodeMetataDefined = _phoneNumberUtil.GetMetadataForRegion(aValidRegionCodeThatDoesNotHaveShortcodeMetadataDefined);
            Assert.That(aValidRegionThatDoesNotHaveShortcodeMetataDefined.ShortCode.NationalNumberPattern, Is.EqualTo("NA"), "Precondition failed. PhoneNumberUtil.GetMetadataForRegion(\"AD\").ShortCode.NationalNumberPattern should not be \"NA\".");

            Assert.That(_sut.IsShortcodeNumber("some number", aValidRegionCodeThatDoesNotHaveShortcodeMetadataDefined), Is.False);
        }

        [Test]
        public void ItShouldReturnTrueForValidShortcodesInUs() {
            const string aValidUsShortcode = "123456";
            Assert.That(_sut.IsShortcodeNumber(aValidUsShortcode, "US"), Is.True);
        }

        [Test]
        public void ItShouldReturnFalseForInvalidShortcodesInUs() {
            const string anInvalidUsShortcodeThatIsTooLong = "1234567";
            Assert.That(_sut.IsShortcodeNumber(anInvalidUsShortcodeThatIsTooLong, "US"), Is.False);
        }
    }
}