import React from 'react';
import {Route, Routes, BrowserRouter} from 'react-router-dom';
import Form from "./components/Form";

function App() {
  return (
     <BrowserRouter>
       <div className="App">
         <div>
           <Routes>
             <Route path='/' element={<Form/>}/>
           </Routes>
         </div>
       </div>
     </BrowserRouter>
  );
}

export default App;
