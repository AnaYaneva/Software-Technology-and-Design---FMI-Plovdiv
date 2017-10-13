
const NAME_MIN_LENGTH=3;
const PASSWORD_MIN_LENGTH=6;
const POSTCODE_LENGTH=4;
const PHONE_LENGTH=10;

const NAME_ALERT_MSG="*For your name you can use only alphabets and \"-\"*";
const NAME_LENGTH_ALERT_MSG="*Your name must be at least 3 symbols long*";
const EMAIL_ALERT_MSG="*Please enter a valid email address*";
const PASSWORD_ALERT_MSG='*For your password you must use at least one uppercase letter, one lowercase letter and one number*';
const PASSWORD_LENGTH_ALERT_MSG="*The password must be at least 6 symbols long*";
const REPEAT_PASSWORD_ALERT_MSG="*The passwords are not the same*";
const POSTCODE_ALERT_MSG="*The postcode must contain only numbers*";
const POSTCODE_LENGTH_ALERT_MSG="*The postcode must be 4 symbols long*";
const PHONE_ALERT_MSG="*The phonenumber must contain only numbers*";
const PHONE_LENGTH_ALERT_MSG="*The phone number must be 10 symbols long*";

function formValidation(){
    let firstname=document.getElementById('name');
    let lastname=document.getElementById('lastname');
    let email=document.getElementById('email');
    let password=document.getElementById('password');
    let passConfirm=document.getElementById('repeatpass');
    let bday=document.getElementById('bday');
    let city=document.getElementById('city');
    let postcode=document.getElementById('postal');
    let phone=document.getElementById('phone');

    let firstname_not=document.getElementById('name-not');
    let firstname_not_length=document.getElementById('name-not-length');
    let lastname_not=document.getElementById('lastname-not');
    let lastname_not_length=document.getElementById('lastname-not-length');
    let email_not=document.getElementById('email-not');
    let password_not=document.getElementById('password-not');
    let password_not_length=document.getElementById('password-not-length');
    let passConfirm_not=document.getElementById('repeatpass-not');
    let bday_not=document.getElementById('bday-not');
    let city_not=document.getElementById('city-not');
    let postcode_not=document.getElementById('postcode-not');
    let postcode_not_length=document.getElementById('postcode-not-length');
    let phone_not=document.getElementById('phone-not');
    let phone_not_length=document.getElementById('phone-not-length');

    let lengthCheck=(lengthMinimum(firstname, NAME_MIN_LENGTH, firstname_not_length, NAME_LENGTH_ALERT_MSG) &&
                     lengthMinimum(lastname, NAME_MIN_LENGTH, lastname_not_length, NAME_LENGTH_ALERT_MSG) &&
                     lengthMinimum(password, PASSWORD_MIN_LENGTH, password_not_length, PASSWORD_LENGTH_ALERT_MSG) &&
                     lengthExact(postcode, POSTCODE_LENGTH, postcode_not_length, POSTCODE_LENGTH_ALERT_MSG) &&
                     lengthExact(phone, PHONE_LENGTH, phone_not_length, PHONE_LENGTH_ALERT_MSG));
    //let checkSelection=trueSelection((city, CITY_DEFAULT, city_not, CITY_ALERT_MSG) &&
    //                   trueSelection(bday, BDAY_DEFAULT, bday_not, BDAY_ALERT_MSG));
    let regexMatch=(inputMatchName(firstname, firstname_not, NAME_ALERT_MSG) &&
                    inputMatchName(lastname, lastname_not, NAME_ALERT_MSG)&&
                    inputMatchEmail(email, email_not, EMAIL_ALERT_MSG) &&
                    inputMatchPassword(password, password_not, PASSWORD_ALERT_MSG) &&
                    inputMatchPostcode(postcode, postcode_not, POSTCODE_ALERT_MSG) &&
                    inputMatchPhone(phone, phone_not, PHONE_ALERT_MSG));
    //let passwordConfirm=passwordConfirm(password, passConfirm, passConfirm_not, ".......");

	return (lengthCheck&&regexMatch);
}

function inputMatchName(inputtext,tag,alertMsg){
    let expression=/^[A-Za-z-]{3,}$/;
	if (inputtext.value.match(expression)) {
		return true;
	}else{
		tag.innerText=alertMsg;
		inputtext.focus();
		return false;
	}
}

function inputMatchEmail(inputtext,tag,alertMsg){
    let expression=/^[A-z0-9\._%+-]+@[A-z0-9.-]+\.[A-z]{2,}$/;
    if (inputtext.value.match(expression)) {
        return true;
    }else{
        tag.innerText=alertMsg;
        inputtext.focus();
        return false;
    }
}

function inputMatchPassword(inputtext,tag,alertMsg){
    let expression=/^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])).{6,}$/;
    if (inputtext.value.match(expression)) {
        return true;
    }else{
        tag.innerText=alertMsg;
        inputtext.focus();
        return false;
    }
}

function inputMatchPostcode(inputtext,tag,alertMsg){
    let expression=/^[0-9]{4}$/;
    if (inputtext.value.match(expression)) {
        return true;
    }else{
        tag.innerText=alertMsg;
        inputtext.focus();
        return false;
    }
}

function inputMatchPhone(inputtext,tag,alertMsg){
    let expression=/^[0-9]{10}$/;
    if (inputtext.value.match(expression)) {
        return true;//
    }else{
        tag.innerText=alertMsg;
        inputtext.focus();
        return false;
    }
}

function lengthMinimum(inputtext, minLength, tag, alertMsg){
	if (inputtext.value.length>=minLength) {
		return true;
	}else{
		tag.innerText=alertMsg;
		inputtext.focus();
		return false;
	}
}

function lengthExact(inputtext,length,tag,alertMsg){
    if (inputtext.value.length==length) {
        return true;
    }else{
       tag.innerText=alertMsg;
        inputtext.focus();
        return false;
    }
}

//function trueSelection(inputtext,stringMatch,tag,alertMsg){
//	if (inputtext.val==stringMatch) {
//		tag.innerText=alertMsg;
//		inputtext.focus();
//		return false;
//	}else{
//		return true;
//	}
//

//function passwordConfirm(password,repeatedPassword,tag, alertMsg) {
//    if (password.value===repeatedPassword.value) {
//        return true;
//    }else{
//        tag.innerText=alertMsg;
//        repeatedPassword.focus();
//        return false;
//    }
//}