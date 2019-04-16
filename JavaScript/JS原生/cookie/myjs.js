//设置cookie
setCookie('user','lizongliang',null,null,null,null);
function setCookie(name,value,expires,path,domain,secure){
	var cookieName = encodeURIComponent(name) + '=' + encodeURIComponent(value);
	if(expires instanceof Date){
		cookieName += ';expires=' + expires; 
	}
	if(path){
		cookieName += ';path' + path;
	}
	if(domain){
		cookieName += ';domain' + domain;
	}
	if(secure){
		cookieName += ';secure' + secure;
	}
	document.cookie = cookieName;
}

//过期时间
function setCookieDate(day){
	var date = null;
	if(typeof day=='number' && day>0){
		date = new Date();
		date.setDate(date.getDate()+day);
	}else{
		throw new Error('date error');
	}
	return date;
}

//获取cookie
function getCookie(name){
	var cookieName = encodeURIComponent(name) + '=';
	var startCookie = document.cookie.indexOf(cookieName);
	var cookieValue = null;

	if(startCookie>-1){
		var endCookie = document.cookie.indexOf(';',startCookie);
		if(endCookie==-1){
			endCookie = document.cookie.length;
		}
		cookieValue = decodeURIComponent(document.cookie.substring(startCookie + cookieName.length, endCookie));
	}
	return cookieValue;
}
alert(getCookie('user'));