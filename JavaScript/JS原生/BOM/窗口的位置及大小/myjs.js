
//alert(window.screenX);	//火狐不支持
// alert(window.innerWidth);
// alert(window.innerHeight);
moveTo(100,100);
var width=window.innerWidth;
var height=window.innerHeight;
if(typeof width!='number'){
	if(document.compatMode=='CSS1Compat'){
		width=document.documentElement.clientWidth;
		height=document.documentElement.clientHeight;
	}else{
		width=document.body.clientWidth;
		height=document.body.clientHeight;
	}
}
alert(width);
alert(height);
