function getArgs(){
	var args=[];
	// var qs=location.search.length>0 ? location.search.substring(1):'';
	var qs="?id=5&search=8/".substring(1);

	var items=qs.split('&');
	var item=null,name=null,value=null;
	for(var i=0;i<items.length;i++)
	{
		item=items[i].split('=');
		name=item[0];
		value=item[1];
		args[name]=value;
	}
	return args;
}
var args=getArgs();
alert(args['id']);
alert(args['search']);