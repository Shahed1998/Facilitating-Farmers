import { Routes, Route } from 'react-router-dom';
import Home from './components/Home/Index';
import Navbar from './components/Navbar/Index';

const App = () => {
  return (
    <>
      <Navbar></Navbar>
      <Routes>
        <Route path='/' element={<Home />} />
      </Routes>
    </>
  );
};

export default App;
