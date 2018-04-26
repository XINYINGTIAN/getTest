//Grid++ Report的辅助JavaScrpt函数
//分解网址中的查询串变量，将其转换为对象的属性/值対方式
function getQVarObj() {
    var p, qVarObj = {};
    var qvars = window.location.search.substr(1).split('&');
    for (var i = 0; i < qvars.length; i++) {
        p = qvars[i].split('=');
        //等号前后的部分分解到两个元素的数组p中
        qVarObj[p[0]] = decodeURIComponent(p[1].replace(/\+/g, " "));
        // decodeURIComponent是指解码
        //解码之前先用replace将+号替换为空格，替换使用了正则表达式/+/g
    }
    return qVarObj;
}