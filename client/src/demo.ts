// data is of type number ans string
let data: number | string;
data = '42';
data = 10;

// objects and interfaces

interface ICar {
    color: string;
    model: string;
    // topSpeed is optional
    topSpeed?: number;
}


const car1: ICar = {
    color: 'blue',
    model: 'bmw'
};

const car2: ICar = {
    color: 'red',
    model: 'mercedes',
    topSpeed: 100
};

// functions
// we return a number
// const multiply = (x: any, y: any): number => {
const multiply1 = (x: number, y: number): number => {
    // return nothing
    //const multiply = (x: number, y: number): void => {
    return x * y;
}

const multiply2 = (x: number, y: number): string => {
    // convert to string
    return (x * y).toString();
}

