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

export function overTake(id){   
    try{
    const promise = axios.put(`https://localhost:5001/api/drivers/${id}/overtake`, {

      });
      const dataPromise = promise.then((respone) => respone.data)  
    return dataPromise; 
    }catch(error) {
        console.log(error.response);
      }
}


export {}