import React from 'react';
import internal from 'stream';

interface Driver{
    id: internal,
    code: string,
    firstName: string,
    lastName: string,
    country: string,
    team: string,
    imgUrl: string,
    place: number
}

interface Props {
    drivers: Driver[]
}



export const Drivers : React.FC<Props> = () => {
      return (
        <div>
          Drivers
        </div>
       
      );
 
}

export default Drivers;
