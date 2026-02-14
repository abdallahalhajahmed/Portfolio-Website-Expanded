import Resume from './components/resume';
import './home.css';
import './custom.css';
import './resume.css';
import Navigation from './components/navigation';
import Home from './components/home';
import Projects from './components/projects';
import Skills from './components/skills';
import About from './components/about';
import Footer from './components/footer';


function App() {
  return (
    <div>
      <Navigation />
      <Home />
      <About />
      <Skills />
      <Projects />
      <Resume />
      <Footer />
    </div>
  );
}

export default App;
