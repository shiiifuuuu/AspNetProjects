const membershipId = document.getElementById('Customer_MembershipTypeId');
const birthdateId = document.getElementById('Customer_BirthDate');
const customerValidation = document.getElementById('customer-validation');
const birthdateError = document.getElementById('birthdate-error-msg');

const birthdateCustomErrorMsg = birthdateId.nextElementSibling.nextElementSibling;

//Checking on clientSide If age < 18 then can not use a membership
function validateCustomerForm() {
    if (membershipId.value >= 2 && birthdateId.value !== null) {
        let birthdate = new Date(birthdateId.value);
        let age = new Date().getFullYear() - birthdate.getFullYear();
        if (age < 18) {
            birthdateCustomErrorMsg.textContent = "User must be 18 years old to use a membership";
            return false;
        } else {
            return true;
        }
    } else {
        return true;
    }
}
//Clearing my custom field text content
birthdateId.addEventListener('keyup', e => {
    birthdateCustomErrorMsg.textContent = "";
});

// const customerName = document.getElementById('Customer_Name');
//
// customerName.addEventListener('keyup', e => {
//     const re = /^[A-Z][a-z]*(\s[A-Z][a-z]*)?$/;
//
//     console.log(re.test(customerName.value));
// });

