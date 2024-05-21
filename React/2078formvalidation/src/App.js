import logo from './logo.svg';
import './App.css';
import React,{useState} from 'react';

function App() {
  const [name,setName]=useState("");
  const [address,setAddress]=useState("");
 
  function formHandler(e){
      if(name.length==0){
        alert("Name cannot be left empty");
      
      }
      if(name.length>10){
        alert("The length of name should not be greater than 10");
      
      }
      if(address.length==0){
        alert("Address cannot be left empty");
      
      }
      if(address.length>10){
        alert("The address of length cannot be greater than 10");
      }
    e.preventDefault();
  }



  

  return (
      
   

    <div>
            <h1>MyForm</h1>
            <form onSubmit={formHandler} >
              <input type="text" placeholder='Enter name' onChange={(e)=>setName(e.target.value) }></input>
              <br></br><br></br>
              <input type="text" placeholder='Enter address' onChange={(e)=>setAddress(e.target.value) } ></input>
              <br></br><br></br>
              <input type="submit" value="Submit"></input>
            </form>
        </div>
  );
}

export default App;

