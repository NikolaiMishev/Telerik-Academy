//You are given a text. Write a function that changes the text in all regions:

var text = "We are <mixcase>vliing</mixcase> in a <upcase>yellow submarine</upcase>." +
    " We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

var inMix = false,
    inLow = false,
    inUp = false;

var MixStart = '<mixcase>';
var MixStop = '</mixcase>';

var UpStart = '<upcase>';
var UpStop = '</upcase>';

var LowStart = '<lowcase>';
var LowStop = '</lowcase>';

var result = [],
    random;
for(var i = 0; i < text.length; i+=1){

    //MixedCase
    if(text.substr(i,MixStop.length) === MixStop){
        inMix = false;
        i += MixStop.length-1;
        continue;
    }
    if(inMix){
        random = Math.random();
        if(random < 0.5){
            result.push(text[i].toLowerCase());
        }
        else{
            result.push(text[i].toUpperCase());
        }
        continue;
    }
    if(text.substr(i,MixStart.length) === MixStart){
        inMix = true;
        i += MixStart.length-1;
        continue;
    }

    //Upper Case
    if(text.substr(i,UpStop.length) === UpStop){
      inUp = false;
      i += UpStop.length-1;
      continue;
  }
    if(inUp){
        result.push(text[i].toUpperCase());
        continue;
    }
    if(text.substr(i,UpStart.length) === UpStart){
      inUp = true;
      i += UpStart.length-1;
      continue;
  }

    //Lower Case
    if(text.substr(i,LowStop.length) === LowStop){
        inLow = false;
        i += LowStop.length-1;
        continue;
    }
    if(inLow){
        result.push(text[i].toLowerCase());
        continue;
    }
    if(text.substr(i,LowStart.length) === LowStart){
        inLow = true;
        i += LowStart.length-1;
        continue;
    }


    result.push(text[i]);
}
console.log(result.join(''));
console.log("We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.")