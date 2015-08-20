//Write a script that parses an URL address given in the format:
// [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.
var text = 'http://telerikacademy.com/Courses/Courses/Details/239';

console.log(parseURL(text));



function parseURL(text){
    var obj ={
    };
    var protocol = true,
        server = false,
        resource = false;
    for(var i = 0; i < text.length; i+=1){
        if(text.substr(i,3) === '://'){
            protocol = false;
            server = true;
            i+=3;
        }
        if(server && text[i] === '/'){
            server = false;
            resource = true;
           // i +=1;
        }

        if(protocol){
            if(!obj["protocol"])
            {
                obj["protocol"] = [];
            }
            obj.protocol.push(text[i]);
        }
        if(server){
            if(!obj['server']){
                obj['server'] = [];
            }
            obj.server.push(text[i]);
        }
        if(resource){
            if(!obj['resource']){
                obj['resource'] = [];
            }
            obj.resource.push(text[i]);
        }

    }

    obj.protocol = obj.protocol.join('');
    obj.server = obj.server.join('');
    obj.resource = obj.resource.join('');
    return obj;
}
