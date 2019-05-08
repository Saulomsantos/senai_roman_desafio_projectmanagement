import React, { Component } from 'react';
import { Text, View, StyleSheet } from 'react-native';

class GerenciarUsuarios extends Component {
    render() {
        return (
            <View style={styles.container}>
                <Text>Gerenciar Usuarios</Text>
            </View>
        )
    }
}

export default GerenciarUsuarios;

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});