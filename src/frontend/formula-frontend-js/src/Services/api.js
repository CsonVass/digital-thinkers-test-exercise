import axios from 'axios';

export function getDrivers(){
    try{
        const promise = axios.get('https://localhost:5001/api/drivers')
        const dataPromise = promise.then((response) => response.data)
        return dataPromise
    }catch (err) {
        console.log(err);
    }
}

export {}