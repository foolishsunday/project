
var box = [
	{
		name:"zhangsan",
		num:1,
		age:18
	},
	{
		name:"lisi",
		num:2,
		age:28
	},
	{
		name:"wangwu",
		num:3,
		age:22
	}
];

addEvent(window,'load',function(){


	// var json = '[{"name" : "zhangsan","num"	: 1	},{"name" : "lisi","num"	: 2	},	{"name" : "wangwu",	"num"	: 3	}]';
	// var box = JSON.parse(json);
	// alert(box[0].name);

	// var json = JSON.stringify(box,['name','age']);	//可只传box
	// alert(json);

	// var json = JSON.stringify(box,function(key,value){
	// 	if(key == 'name')
	// 		return value;
	// 	else 
	// 		return 'not work';

	// });
	// alert(json);

	// var json = JSON.stringify(box,['name','age'],4);	//数字表示缩进量，便于查看
	// alert(json);

	var json = JSON.stringify(box,null,4);	//可用null
	alert(json);


});


//-------------------------------------------------------------------------------//
// var box = [
// 	{
// 		name:'zhangsan',
// 		num:1,
// 		age:18,
// 		toJSON:function(){	//只返回name
// 			return this.name;
// 		}
// 	},
// 	{
// 		name:'lisi',
// 		num:2,
// 		age:28,
// 		toJSON:function(){
// 			return this.name;
// 		}
// 	},
// 	{
// 		name:'wangwu',
// 		num:3,
// 		age:22,
// 		toJSON:function(){
// 			return this.name;
// 		}
// 	}
// ];

// addEvent(window,'load',function(){

// 	var json = JSON.stringify(box,null,4);	
// 	alert(json);


// });
//-------------------------------------------------------------------------------//

function addEvent(obj,type,fn){
	if(obj.addEventListener){
		obj.addEventListener(type,fn,false);
	}else if(obj.attachEvent){
		obj.attachEvent('on'+type,fn);
	}
}

function removeEvent(obj,type,fn){
	if(obj.removeEventListener){
		obj.removeEventListener(type,fn,false);
	}else if(obj.detachEvent){
		obj.detachEvent('on'+type,fn);
	}
}

//跨浏览器阻止默认行为
function preDef(evt){
	var e = evt || window.event;
	if(e.preventDefault){
		e.preventDefault();
	}
	else 
		e.returnValue = false;
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

function createXMLDom(){
  if (window.ActiveXObject) 
   var xmldoc=new ActiveXObject("Microsoft.XMLDOM");
  else
   if (document.implementation&&document.implementation.createDocument)
    var xmldoc=document.implementation.createDocument("","doc",null);
  xmldoc.async = false;
  //为了和FireFox一至，这里不能改为False;
  xmldoc.preserveWhiteSpace=true;
  return xmldoc;
}