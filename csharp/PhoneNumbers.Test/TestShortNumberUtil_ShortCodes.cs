using NUnit.Framework;

namespace PhoneNumbers.Test.TestShortNumberUtil_ShortCodes
{
    public class GivenAShortNumberUtil
    {
        protected ShortNumberUtil _sut;

        [SetUp]
        public void Given() {
            PhoneNumberUtil.ResetInstance();
            _sut = new ShortNumberUtil(PhoneNumberUtil.GetInstance());
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
            const string aValidRegionCodeThatDoesNotHaveShortcodeMetadataDefined = "";
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