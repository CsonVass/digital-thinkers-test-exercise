import {useState} from 'react';
import Drivers from './Drivers';
import {getDrivers} from '../Services/api';

function App() {
  const [drivers, setDrivers] = useState(getDrivers());


  console.log(drivers);
  return (
    <div>
      
    </div>
   
  );
}

export default App;
