import React,{useState} from 'react';
function Login(){
    const [user,setUser]=useState("");
    const [password,setPassword]=useState("");
    const [userError,setUserErr]=useState(false);
    const [passwordError,setPasswordErr]=useState(false);
  function  loginHandle(e){
        if(user.length<3 || password.length<3){
            alert("Type correct values")
        }
        else{
            alert("All good");
        }
        e.preventDefault();
    }
    function userHandler(e){
        let item=e.target.value;
        if(item.length<3){
            setUserErr(true);
        }
        else{
            setUserErr(false);
        }
        setUser(item);
    }
    function passwordHandler(e){
        let item=e.target.value;
        if(item.length<3){
            setPasswordErr(true);
        }
        else{
            setPasswordErr(false);
        }
        setPassword(item);
    }
    return (
    <div>
        <h1>Login</h1>
        <form onSubmit={loginHandle}>
        <input type="text" placeholder="Enter user id" onChange={userHandler} />
        {userError?<span>User not valid</span>:""}
        <br></br><br></br>
        <input type="text" placeholder="Enter user password" onChange={passwordHandler} />
         {passwordError?<span>Password not valid</span>:""}
        <br></br><br></br>
        <input type="submit" value="Submit"/>
        </form>
    </div>
    )
}

export default Login;