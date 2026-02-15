// import MyPic from '../images/MyPic.jpeg';
import SpartaPic from '../images/Sparta Global.png';
import SpartaPic2 from '../images/Sparta2.jpeg';
import SpartaPic3 from '../images/Sparta3.png';




function Navigation() {
  return (
    <nav className="bg-light border-bottom border-body d-flex overflow-hidden" style={{ height: "70px",}}>
    <input type="checkbox" id="sidebar-active"></input>
    <label for="sidebar-active" className="open-sidebar-button">
      <svg xmlns="http://www.w3.org/2000/svg" height="40" viewBox="0 -960 960 960" width="40"><path d="M120-240v-80h720v80H120Zm0-200v-80h720v80H120Zm0-200v-80h720v80H120Z"/></svg>
    </label>
    <label id="overlay" for="sidebar-active"></label>
    <div className="links-container h-100">
      <label for="sidebar-active" className="close-sidebar-button">
        <svg xmlns="http://www.w3.org/2000/svg" height="40" viewBox="0 -960 960 960" width="40"><path d="m256-200-56-56 224-224-224-224 56-56 224 224 224-224 56 56-224 224 224 224-56 56-224-224-224 224Z"/></svg>
      </label>
      <a className="nav-brand" href="#home">
        <img src={SpartaPic3} alt="Sparta Global" className="nav-pic" />
      </a> 
      <li><a href="#about">About</a></li>
      <li><a href="#skills">Skills</a></li>
      <li><a href="#projects">Projects</a></li>
      <li><a href="#resume">Profile</a></li>
    </div>
  </nav>

  );
}

export default Navigation;
