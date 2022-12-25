import { Routes, Route } from 'react-router-dom';
import Home from './components/Home/Index';
import Navbar from './components/Navbar/Index';
import i18next from 'i18next';
import Login from './components/Login/Index';
import Signup from './components/Login/Signup';

const App = () => {
  window.translateTo = (lang) => {
    i18next.changeLanguage(lang);
  };

  return (
    <>
      <Navbar></Navbar>
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='/login' element={<Login />} />
        <Route path='/signup' element={<Signup />} />
      </Routes>
    </>
  );
};

export default App;
