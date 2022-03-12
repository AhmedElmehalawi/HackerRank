'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

/*
the bitwise operaor (&) acts like this
    ex:  3 & 9
    sol:
    3 as binary: 0011
    9 as binary: 1001
    so, 0011 & 1001 = 0001
    so the return value is 1
*/
// n is the max number in s[1:n]
// the maxBitwiseValue should be less than a specific number: k  
function getMaxLessThanK (n,k){
    let maxValue = 0;
    
    for(let a=1 ; a<=n ; a++){
        for(let b=a+1 ; b<=n ; b++){
            let AnBValue =  a & b;
            if(AnBValue<k && AnBValue>maxValue){
                maxValue = AnBValue;
            }                
        }
    }
    return maxValue;
}

function main() {
    const q = +(readLine());
    
    for (let i = 0; i < q; i++) {
        const [n, k] = readLine().split(' ').map(Number);
        
        console.log(getMaxLessThanK(n, k));
    }
}
