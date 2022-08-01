import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';

import Drivers from './Drivers';


function App({data}) {  

  return (
    <Router>
      <div>
        <Routes>
        <Route path="/drivers" element={<Drivers
          drivers = {data}
         />}/>

        </Routes>
      </div>
    </Router>
    
  );
}

export default App;
